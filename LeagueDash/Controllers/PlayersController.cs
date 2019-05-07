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
        public async Task<IActionResult> Index()
        {
            PlayerListViewModel viewModel = new PlayerListViewModel();

            viewModel.PlayerList = await (
                from au in _context.ApplicationUsers
                join t in _context.Team on au.TeamId equals t.Id into sub
                from subq in sub.DefaultIfEmpty()
                select new PlayerDetailsViewModel
                {
                    Player = new ApplicationUser
                    {
                        Id = au.Id,
                        FirstName = au.FirstName,
                        LastName = au.LastName,
                        RoleId = au.RoleId,
                        TeamId = au.TeamId
                    },
                    PlayerTeam = subq.Name
                }).ToListAsync();

            return View(viewModel);
        }

        // GET: Players/Details/5
        public async Task<IActionResult> Details(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }


            var player = await _userManager.FindByIdAsync(id.ToString());
            if (player == null)
            {
                return NotFound();
            }

            var team = await _context.Team
                .FirstOrDefaultAsync(t => t.Id == player.TeamId);

            PlayerDetailsViewModel viewModel = new PlayerDetailsViewModel
            {
                Player = player,
                PlayerTeam = team == null ? "" : team.Name
            };

            return View(viewModel);
        }

        // GET: Players/Edit/5
        /*[Authorize]
        public async Task<IActionResult> Edit(Guid id)
        {
            /*if (id == null)
            {
                return NotFound();
            }

            var player = await _userManager.FindByIdAsync(id.ToString());
            if (player == null)
            {
                return NotFound();
            }

            return View(player);
        }*/

        // POST: Players/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpGet]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Edit(string id, [Bind("Id, FirstName, LastName, RoleId")] ApplicationUser player)
        {
            if (id != player.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var currentUser = await GetCurrentUserAsync();
                player.TeamId = currentUser.TeamId;
                await _userManager.UpdateAsync(player);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}