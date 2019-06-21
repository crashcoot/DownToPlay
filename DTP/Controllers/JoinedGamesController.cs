using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DTP.Data;
using DTP.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace DTP.Controllers
{
    public class JoinedGamesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public JoinedGamesController(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        public ActionResult JoinGame(int gameID)
        {
            string userID = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            JoinedGame tmp = new JoinedGame();
            tmp.GameID = gameID;
            tmp.UserID = userID;
            _context.JoinedGame.Add(tmp);
            Game gameEntity = _context.Game.Find(gameID);
            gameEntity.CurrentPlayers++;
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult LeaveGame(int gameID)
        {
            string userID = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            JoinedGame jg = _context.JoinedGame.Where(x => x.GameID == gameID && x.UserID == userID).FirstOrDefault();
            Game gameEntity = _context.Game.Find(gameID);
            if (jg != null)
            {
                _context.Remove(jg);
                gameEntity.CurrentPlayers--;
                _context.SaveChanges();
            }
            return RedirectToAction("Index", "Home");
        }

        // GET: JoinedGames
        public async Task<IActionResult> Index()
        {
            return View(await _context.JoinedGame.ToListAsync());
        }

        // GET: JoinedGames/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var joinedGame = await _context.JoinedGame
                .FirstOrDefaultAsync(m => m.ID == id);
            if (joinedGame == null)
            {
                return NotFound();
            }

            return View(joinedGame);
        }

        // GET: JoinedGames/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: JoinedGames/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,GameID,UserID")] JoinedGame joinedGame)
        {
            if (ModelState.IsValid)
            {
                _context.Add(joinedGame);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(joinedGame);
        }

        // GET: JoinedGames/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var joinedGame = await _context.JoinedGame.FindAsync(id);
            if (joinedGame == null)
            {
                return NotFound();
            }
            return View(joinedGame);
        }

        // POST: JoinedGames/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,GameID,UserID")] JoinedGame joinedGame)
        {
            if (id != joinedGame.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(joinedGame);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JoinedGameExists(joinedGame.ID))
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
            return View(joinedGame);
        }

        // GET: JoinedGames/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var joinedGame = await _context.JoinedGame
                .FirstOrDefaultAsync(m => m.ID == id);
            if (joinedGame == null)
            {
                return NotFound();
            }

            return View(joinedGame);
        }

        // POST: JoinedGames/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var joinedGame = await _context.JoinedGame.FindAsync(id);
            _context.JoinedGame.Remove(joinedGame);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JoinedGameExists(int id)
        {
            return _context.JoinedGame.Any(e => e.ID == id);
        }
    }
}
