using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeagueDash.Data;
using LeagueDash.Models;
using LeagueDash.Models.PlayerViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LeagueDash.Controllers
{
    public class PlayersController : Controller
    {
        private readonly ApplicationDbContext _context;

        private readonly UserManager<ApplicationUser> _userManager;

        public PlayersController(ApplicationDbContext ctx,
            UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _context = ctx;
        }

        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        // GET: Players
        [Authorize]
        public async Task<IActionResult> Index(
            bool filterAgents,
            string sortOrder,
            string currentFilter,
            string searchString)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["PositionSortParm"] = sortOrder == "Position" ? "position_desc" : "Position";
            ViewData["TeamSortParm"] = sortOrder == "Team" ? "team_desc" : "Team";

            PlayerListViewModel viewModel = new PlayerListViewModel();

            viewModel.PlayerList = await (
                from au in _context.ApplicationUsers
                join t in _context.Team on au.TeamId equals t.Id into sub1
                from subq1 in sub1.DefaultIfEmpty()
                join p in _context.Position on au.PositionId equals p.Id into sub2
                from subq2 in sub2.DefaultIfEmpty()
                where au.RoleId != 3
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
                    PlayerTeam = subq1.Name,
                    Position = subq2.Name
                }).ToListAsync();

            if (!String.IsNullOrEmpty(searchString))
            {
                viewModel.PlayerList = viewModel.PlayerList.Where(p => p.FullName.Contains(searchString)).ToList();
            }
            if (filterAgents)
            {
                viewModel.PlayerList = viewModel.PlayerList.Where(p => p.Player.TeamId == null).ToList();
            }

            switch (sortOrder)
            {
                case "name_desc":
                    viewModel.PlayerList = viewModel.PlayerList.OrderByDescending(p => p.FullName).ToList();
                    break;
                case "Position":
                    viewModel.PlayerList = viewModel.PlayerList.OrderBy(p => p.Position).ToList();
                    break;
                case "position_desc":
                    viewModel.PlayerList = viewModel.PlayerList.OrderByDescending(p => p.Position).ToList();
                    break;
                case "Team":
                    viewModel.PlayerList = viewModel.PlayerList.OrderBy(p => p.PlayerTeam).ToList();
                    break;
                case "team_desc":
                    viewModel.PlayerList = viewModel.PlayerList.OrderByDescending(p => p.PlayerTeam).ToList();
                    break;
                default:
                    viewModel.PlayerList = viewModel.PlayerList.OrderBy(p => p.FullName).ToList();
                    break;
            }

            return View(viewModel);
        }

        // GET: Players/Details/5
        [Authorize]
        public async Task<IActionResult> Details(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var player =  await _context.ApplicationUsers.FirstOrDefaultAsync(t => t.Id == id.ToString());
            if (player == null)
            {
                return NotFound();
            }

            var team = await _context.Team
                .FirstOrDefaultAsync(t => t.Id == player.TeamId);

            var position = await _context.Position
                .FirstOrDefaultAsync(p => p.Id == player.PositionId);

            var currentUser = await GetCurrentUserAsync();

            PlayerDetailsViewModel viewModel = new PlayerDetailsViewModel
            {
                Player = player,
                PlayerTeam = team == null ? "" : team.Name,
                Position = position.Name,
                IsOnTeam = (player.TeamId == currentUser.TeamId &&
                    currentUser.TeamId != null && 
                    player.TeamId != null) ? true : false
            };

            return View(viewModel);
        }

        // POST: Players/Details/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Details(Guid Id, PlayerDetailsViewModel viewModel)
        {
            var currentUser = await GetCurrentUserAsync();
            if (currentUser.RoleId == 2 || currentUser.RoleId == 3)
            {
                ApplicationUser player = await _userManager.FindByIdAsync(Id.ToString());

                if (player.Id == Id.ToString() && 
                    player.TeamId == null && 
                    currentUser.TeamId != null &&
                    player.RoleId != 2 && 
                    player.RoleId != 3)
                {
                    player.TeamId = currentUser.TeamId;
                    await _userManager.UpdateAsync(player);
                    await _context.SaveChangesAsync();
                } else if (player.Id == Id.ToString() && 
                    player.TeamId == currentUser.TeamId && 
                    player.TeamId != null && 
                    currentUser.TeamId != null && 
                    player.RoleId != 2 && 
                    player.RoleId != 3)
                {
                    player.TeamId = null;
                    await _userManager.UpdateAsync(player);
                    await _context.SaveChangesAsync();
                }
                return RedirectToAction(nameof(Index));
            } else
            {
                return View();
            }
        }
    }
}