using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DTP.Models;
using Microsoft.AspNetCore.Identity;

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
        public DbSet<IdentityUser> Users { get; set; }
    }
}
