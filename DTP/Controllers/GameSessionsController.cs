using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using DTP.Data;
using DTP.Models;
using DTP.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DTP.Controllers
{
    public class GameSessionsController : BaseController
    {

        public GameSessionsController(ApplicationDbContext db, IHttpContextAccessor httpContextAccessor) : base(db, httpContextAccessor)
        {
            
        }

        public new IActionResult Index()
        {
            return RedirectToAction("AllGames");
        }

        public new IActionResult Test()
        {
            return View();
        }

        public IActionResult AllGames()
        {
            GameSessionViewModel GameSessionViewModel = new GameSessionViewModel();
            GameSessionViewModel.JoinedGames = _context.JoinedGame.ToList();
            GameSessionViewModel.Games = _context.Game.ToList();
            GameSessionViewModel.CurrentUserID = GetCurrentUserID();
            foreach(JoinedGame jg in GameSessionViewModel.JoinedGames)
            {
                if (jg.UserID == GameSessionViewModel.CurrentUserID)
                {
                    GameSessionViewModel.CurrentUserGames.Add(jg.GameID);
                }
            }

            return View(GameSessionViewModel);
        }

        public IActionResult YourJoinedGames()
        {
            GameSessionViewModel GameSessionViewModel = new GameSessionViewModel();
            GameSessionViewModel.JoinedGames = _context.JoinedGame.ToList();
            GameSessionViewModel.Games = _context.Game.ToList();
            GameSessionViewModel.CurrentUserID = GetCurrentUserID();
            foreach (JoinedGame jg in GameSessionViewModel.JoinedGames)
            {
                if (jg.UserID == GameSessionViewModel.CurrentUserID)
                {
                    GameSessionViewModel.CurrentUserGames.Add(jg.GameID);
                }
            }

            return View(GameSessionViewModel);
        }

        public IActionResult YourCreatedGames()
        {
            GameSessionViewModel GameSessionViewModel = new GameSessionViewModel();
            GameSessionViewModel.JoinedGames = _context.JoinedGame.ToList();
            GameSessionViewModel.Games = _context.Game.ToList();
            GameSessionViewModel.CurrentUserID = GetCurrentUserID();
            foreach (JoinedGame jg in GameSessionViewModel.JoinedGames)
            {
                if (jg.UserID == GameSessionViewModel.CurrentUserID)
                {
                    GameSessionViewModel.CurrentUserGames.Add(jg.GameID);
                }
            }

            return View(GameSessionViewModel);
        }
        

        public ActionResult JoinGame(int gameID, string view)
        {
            if (!UserInGame(gameID))
            {
                string userID = GetCurrentUserID();
                JoinedGame tmp = new JoinedGame();
                tmp.GameID = gameID;
                tmp.UserID = userID;
                tmp.Username = _context.Users.Find(userID).UserName;
                _context.JoinedGame.Add(tmp);
                Game gameEntity = _context.Game.Find(gameID);
                gameEntity.CurrentPlayers++;
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult LeaveGame(int gameID)
        {
            string userID = GetCurrentUserID();
            JoinedGame jg = _context.JoinedGame.Where(x => x.GameID == gameID && x.UserID == userID).FirstOrDefault();
            Game gameEntity = _context.Game.Find(gameID);
            if (jg != null)
            {
                _context.Remove(jg);
                gameEntity.CurrentPlayers--;
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public bool UserInGame(int gameID)
        {
            string userID = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            JoinedGame jg = _context.JoinedGame.Where(x => x.GameID == gameID && x.UserID == userID).FirstOrDefault();
            return (jg != null);
        }
    }
}