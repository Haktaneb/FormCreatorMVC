using System;
using FormCreatorMVC.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace FormCreatorMVC.DAL
{
    public class AppDbContext : DbContext
    {


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
           
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Forms>()
                .HasKey(c => new { c.ID, c.CreatedBy });
            modelBuilder.Entity<Forms>()
              .Property(c =>  c.CreatorName).IsRequired();
        }
        public DbSet<Forms> Forms { get; set; }
    }
}
