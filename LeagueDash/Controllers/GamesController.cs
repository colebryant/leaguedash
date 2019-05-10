using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LeagueDash.Data;
using LeagueDash.Models;
using LeagueDash.Models.GameViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace LeagueDash.Controllers
{
    public class GamesController : Controller
    {
        private readonly ApplicationDbContext _context;

        private readonly UserManager<ApplicationUser> _userManager;

        public GamesController(ApplicationDbContext context,
            UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _context = context;
        }

        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        // GET: Games
        [Authorize]
        public async Task<IActionResult> Index()
        {
            var currentUser = await GetCurrentUserAsync();

            GameListViewModel viewModel = new GameListViewModel();

            viewModel.CurrentUserRoleId = currentUser.RoleId;
            viewModel.GameList = await (
                from g in _context.Game
                join t in _context.Team on g.TeamAId equals t.Id into sub1
                from subq1 in sub1.DefaultIfEmpty()
                join t in _context.Team on g.TeamBId equals t.Id into sub2
                from subq2 in sub2.DefaultIfEmpty()
                select new GameDetailsViewModel
                {
                    Game = new Game
                    {
                        Id = g.Id,
                        Location = g.Location,
                        GameTime = g.GameTime,
                        TeamAId = g.TeamAId,
                        TeamBId = g.TeamBId,
                        TeamAScore = g.TeamAScore,
                        TeamBScore = g.TeamBScore
                    },
                    TeamAName = subq1.Name,
                    TeamBName = subq2.Name
                }).ToListAsync();

            return View(viewModel);
        }

        // GET: Games/Details/5
        [Authorize]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var game = await _context.Game
                .FirstOrDefaultAsync(g => g.Id == id);
            if (game == null)
            {
                return NotFound();
            }

            var teamA = await _context.Team
                .FirstOrDefaultAsync(t => t.Id == game.TeamAId);
            if (teamA == null)
            {
                return NotFound();
            }

            var teamB = await _context.Team
                .FirstOrDefaultAsync(t => t.Id == game.TeamBId);
            if (teamB == null)
            {
                return NotFound();
            }

            GameDetailsViewModel viewModel = new GameDetailsViewModel
            {
                Game = game,
                TeamAName = teamA.Name,
                TeamBName = teamB.Name
            };

            return View(viewModel);
        }

        // GET: Games/Create
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Create()
        {
            var currentUser = await GetCurrentUserAsync();
            if (currentUser.RoleId == 3)
            {
                var Teams = _context.Team.ToList();

                List<SelectListItem> TeamAOptions = new List<SelectListItem>();

                TeamAOptions.Insert(0, new SelectListItem
                {
                    Text = "Select Team A...",
                    Value = null,
                    Selected = true
                });

                List<SelectListItem> TeamBOptions = new List<SelectListItem>();

                TeamBOptions.Insert(0, new SelectListItem
                {
                    Text = "Select Team B...",
                    Value = null,
                    Selected = true
                });

                foreach (var t in Teams)
                {
                    SelectListItem li = new SelectListItem
                    {
                        Value = t.Id.ToString(),
                        Text = t.Name
                    };
                    TeamAOptions.Add(li);
                    TeamBOptions.Add(li);
                }

                GameCreateViewModel viewModel = new GameCreateViewModel
                {
                    TeamAOptions = TeamAOptions,
                    TeamBOptions = TeamBOptions
                };
                return View(viewModel);
            } else
            {
                return View();
            }
        }

        // POST: Games/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Create(GameCreateViewModel viewModel)
        {
            var currentUser = await GetCurrentUserAsync();
            if (currentUser.RoleId == 3)
            {
                if (ModelState.IsValid)
                {
                    _context.Add(viewModel.Game);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                return View(viewModel);
            } else {
                return View(viewModel);
            }
        }

        // GET: Games/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            var currentUser = await GetCurrentUserAsync();
            if (currentUser.RoleId == 2 || currentUser.RoleId == 3)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var game = await _context.Game.FindAsync(id);
                if (game == null)
                {
                    return NotFound();
                }
                return View(game);
            } else
            {
                return View();
            }
        }

        // POST: Games/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Edit(int id, [Bind("Id,GameTime,Location,TeamAId,TeamBId,TeamAScore,TeamBScore")] Game game)
        {
            var currentUser = await GetCurrentUserAsync();
            if (currentUser.RoleId == 3)
            {
                    if (id != game.Id)
                {
                    return NotFound();
                }

                if (ModelState.IsValid)
                {
                    try
                    {
                        _context.Update(game);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!GameExists(game.Id))
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
                return View(game);
            } else
            {
                return View();
            }
        }

        // GET: Games/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            var currentUser = await GetCurrentUserAsync();
            if (currentUser.RoleId == 3)
            {
                    if (id == null)
                {
                    return NotFound();
                }

                var game = await _context.Game
                    .FirstOrDefaultAsync(m => m.Id == id);
                if (game == null)
                {
                    return NotFound();
                }

                return View(game);
            } else
            {
                return View();
            }
        }

        // POST: Games/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var currentUser = await GetCurrentUserAsync();
            if (currentUser.RoleId == 3)
            {
                var game = await _context.Game.FindAsync(id);
                _context.Game.Remove(game);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            } else
            {
                return View();
            }
        }

        private bool GameExists(int id)
        {
            return _context.Game.Any(e => e.Id == id);
        }
    }
}
