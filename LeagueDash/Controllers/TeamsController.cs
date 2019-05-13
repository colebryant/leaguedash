using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LeagueDash.Data;
using LeagueDash.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using LeagueDash.Models.TeamViewModels;
using LeagueDash.Models.PlayerViewModels;

namespace LeagueDash.Controllers
{
    public class TeamsController : Controller
    {
        private readonly ApplicationDbContext _context;

        private readonly UserManager<ApplicationUser> _userManager;

        public TeamsController(ApplicationDbContext ctx,
            UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _context = ctx;
        }

        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        // GET: Teams
        [Authorize]
        public async Task<IActionResult> Index()
        {
            var currentUser = await GetCurrentUserAsync();

            TeamListViewModel viewModel = new TeamListViewModel();

            viewModel.CurrentUserRoleId = currentUser.RoleId;
            viewModel.TeamList = await (
                from t in _context.Team
                join au in _context.ApplicationUsers on t.CaptainId equals au.Id into sub
                from subq in sub.DefaultIfEmpty()
                select new TeamDetailsViewModel
                {
                    Team = new Team
                    {
                        Id = t.Id,
                        Name = t.Name,
                        DateCreated = t.DateCreated,
                        CaptainId = t.CaptainId  
                    },
                    TeamCaptainFirstName = subq.FirstName,
                    TeamCaptainLastName = subq.LastName,
                    Wins = _context.Game.Where(g => (g.TeamAId == t.Id && g.TeamAScore > g.TeamBScore) || (g.TeamBId == t.Id && g.TeamBScore > g.TeamAScore)).Count(),
                    Losses = _context.Game.Where(g => (g.TeamAId == t.Id && g.TeamAScore < g.TeamBScore) || (g.TeamBId == t.Id && g.TeamBScore < g.TeamAScore)).Count(),
                    Ties = _context.Game.Where(g => (g.TeamAId == t.Id || g.TeamBId == t.Id) && (g.TeamAScore == g.TeamBScore && g.TeamAScore != null && g.TeamBScore != null)).Count()

        }).OrderByDescending(t => t.RankingScore).ToListAsync();

            return View(viewModel);
        }

        // GET: Teams/Details/5
        [Authorize]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var team = await _context.Team
                .FirstOrDefaultAsync(t => t.Id == id);
            if (team == null)
            {
                return NotFound();
            }
            var captain = await _userManager.FindByIdAsync(team.CaptainId);

            int gameWins = _context.Game.Where(g => (g.TeamAId == team.Id && g.TeamAScore > g.TeamBScore) || (g.TeamBId == team.Id && g.TeamBScore > g.TeamAScore)).Count();
            int gameLosses = _context.Game.Where(g => (g.TeamAId == team.Id && g.TeamAScore < g.TeamBScore) || (g.TeamBId == team.Id && g.TeamBScore < g.TeamAScore)).Count();
            int gameTies = _context.Game.Where(g => (g.TeamAId == team.Id || g.TeamBId == team.Id) && (g.TeamAScore == g.TeamBScore && g.TeamAScore != null && g.TeamBScore !=null)).Count();

            var players = await (
                from au in _context.ApplicationUsers
                where au.TeamId == team.Id
                join p in _context.Position on au.PositionId equals p.Id into sub
                from subq in sub.DefaultIfEmpty()
                select new PlayerDetailsViewModel
                {
                    Player = new ApplicationUser
                    {
                        Id = au.Id,
                        FirstName = au.FirstName,
                        LastName = au.LastName,
                        PositionId = au.PositionId,
                        RoleId = au.RoleId,
                        TeamId = au.TeamId
                    },
                    Position = subq.Name
                }).ToListAsync();

            var currentUser = await GetCurrentUserAsync();

            TeamDetailsViewModel viewModel = new TeamDetailsViewModel
            {
                Team = team,
                TeamCaptainFirstName = captain.FirstName,
                TeamCaptainLastName = captain.LastName,
                CurrentUser = currentUser,
                PlayerList = players,
                Wins = gameWins,
                Losses = gameLosses,
                Ties = gameTies
            };

            return View(viewModel);
        }

        // GET: Teams/Create
        [Authorize]
        public async Task<IActionResult> Create()
        {
            var user = await GetCurrentUserAsync();
            if (user.RoleId == 1)
            {
                return View("../Home/AuthorizeError");
            } else
            {
                TeamCreateViewModel viewModel = new TeamCreateViewModel();
                return View(viewModel);
            }
        }

        // POST: Teams/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Create(TeamCreateViewModel viewModel)
        {
            ModelState.Remove("Team.CaptainId");
            ModelState.Remove("Team.DateCreated");

            var user = await GetCurrentUserAsync();
            if (user.RoleId == 1)
            {
                return View("../Home/AuthorizeError");
            } else
            {
                if (ModelState.IsValid)
                {
                    viewModel.Team.CaptainId = user.Id;
                    viewModel.Team.DateCreated = DateTime.Now;
                    _context.Add(viewModel.Team);
                    await _context.SaveChangesAsync();
                    user.TeamId = viewModel.Team.Id;
                    await _userManager.UpdateAsync(user);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Details", new { @id = viewModel.Team.Id });
                }
                return View(viewModel);
            }

        }

        // GET: Teams/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var team = await _context.Team.FindAsync(id);
            if (team == null)
            {
                return NotFound();
            }
            return View(team);
        }

        // POST: Teams/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,DateCreated,CaptainId")] Team team)
        {
            if (id != team.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(team);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TeamExists(team.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(team);
        }

        // GET: Teams/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var team = await _context.Team
                .FirstOrDefaultAsync(m => m.Id == id);
            if (team == null)
            {
                return NotFound();
            }

            return View(team);
        }

        // POST: Teams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var team = await _context.Team.FindAsync(id);
            _context.Team.Remove(team);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TeamExists(int id)
        {
            return _context.Team.Any(e => e.Id == id);
        }
    }
}
