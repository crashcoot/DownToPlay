using DTP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DTP.ViewModels
{
    public class GameSessionViewModel
    {
        public List<JoinedGame> JoinedGames { get; set; }
        public List<Game> Games { get; set; }
        public string CurrentUserID { get; set; }
    }
}
