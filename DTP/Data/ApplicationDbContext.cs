using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DTP.Models;

namespace DTP.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<DTP.Models.Game> Game { get; set; }
        public DbSet<DTP.Models.JoinedGame> JoinedGame { get; set; }
    }
}
