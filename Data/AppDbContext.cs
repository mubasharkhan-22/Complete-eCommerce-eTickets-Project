using eCommerce.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            // here i give the instruction to translator that Actor_Movie has two Keys
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new
            {
                am.MovieId,
                am.ActorId
            });
            // and here i am saying that join table/join class  "Actor_Movie" has relationship table and that  join table have foriegn key related to that relationship table in simple word movieId is a foreign key  in Actor_Movie table and 
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Movie).WithMany(am => am.Actor_Movies).HasForeignKey(m => m.MovieId);
            modelBuilder.Entity<Actor_Movie>().HasOne(a => a.Actor).WithMany(am => am.Actor_Movies).HasForeignKey(m => m.ActorId);
            
            base.OnModelCreating(modelBuilder);
        }

        // we tell the translator/AppDBContext that you have below mention tables
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Actor_Movie> Actor_Movies { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Cenima> Cenimas { get; set; }
        public DbSet<Producer> Producers { get; set; }

    }
}
