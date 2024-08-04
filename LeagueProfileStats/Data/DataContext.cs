using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LeagueProfileStats.Model;


namespace LeagueProfileStats.Data
{
    public class DataContext : DbContext {
        
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
            ProfileContext = Set<PlayerProfile>();
        }

        public DbSet<PlayerProfile> ProfileContext { get; set; }

        protected override void OnModelCreating(ModelBuilder builder) {
            
            builder.Entity<PlayerProfile>().Property(res => res.Id).ValueGeneratedOnAdd();

            builder.Entity<PlayerProfile>().Property(res => res.Nome).IsRequired();
            
            builder.Entity<PlayerProfile>().HasKey(type => new {type.Rank, type.Tier});
        }
    }
}