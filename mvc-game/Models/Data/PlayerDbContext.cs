using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace mvc_game.Models.Data
{
    public class PlayerDbContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
    }
}