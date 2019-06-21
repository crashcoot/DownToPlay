using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DTP.Models;
using DTP.Data;
using DTP.ViewModels;

namespace DTP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public IActionResult Index()
        {
            GameSessionViewModel GameSessionViewModel = new GameSessionViewModel();
            GameSessionViewModel.JoinedGames = _context.JoinedGame.ToList();
            GameSessionViewModel.Games = _context.Game.ToList();

            return View(GameSessionViewModel);
        }

        public HomeController(ApplicationDbContext db)
        {
            _context = db;
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
