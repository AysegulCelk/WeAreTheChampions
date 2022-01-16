using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeAreTheChampions.Mapping;
using WeAreTheChampions.Models;

namespace WeAreTheChampions.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("server=.;database=Championsdb;trusted_connection=true")
        {

        }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Color>Colors { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Player> Players { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new TeamMapping());
            modelBuilder.Configurations.Add(new ColorMapping());
            modelBuilder.Configurations.Add(new MatchMapping());
            modelBuilder.Configurations.Add(new PlayerMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}
    

    

