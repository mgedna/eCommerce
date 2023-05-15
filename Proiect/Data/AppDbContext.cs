using Microsoft.EntityFrameworkCore;
using Proiect.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Proiect.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Cinema>()
                .HasOne(c => c.Address)
                .WithOne(a => a.Cinema)
                .HasForeignKey<Address>(a => a.CinemaId)
                .OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<Movie>()
                .HasOne(m => m.Cinema)
                .WithMany(c => c.Movies)
                .HasForeignKey(m => m.CinemaId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Actor_Movie>()
                .HasKey(am => new { am.ActorId, am.MovieId });

            modelBuilder.Entity<Actor_Movie>()
                .HasOne(m => m.Movie)
                .WithMany(am => am.Actors_Movies)
                .HasForeignKey(m => m.MovieId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Actor_Movie>().
                HasOne(m => m.Actor).
                WithMany(am => am.Actors_Movies).
                HasForeignKey(m => m.ActorId)
                .OnDelete(DeleteBehavior.Cascade);


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor_Movie> Actors_Movies { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
