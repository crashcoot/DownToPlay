﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DTP.Models
{
    public class Game
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MinPlayers { get; set; }
        public int MaxPlayers { get; set; }
        public int CurrentPlayers { get; set; }

        public string CreatedBy { get; set; }
    }
}
