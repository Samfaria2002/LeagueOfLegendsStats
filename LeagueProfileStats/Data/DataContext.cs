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
            ProfileContext = Set<Profile>();
        }

        public DbSet<Profile> ProfileContext { get; set; }

        protected override void OnModelCreating(ModelBuilder builder) {
            
            builder.Entity<Profile>().Property(res => res.Id).ValueGeneratedOnAddOrUpdate();

            builder.Entity<Profile>().Property(res => res.Nome).IsRequired();
        }
    }
}