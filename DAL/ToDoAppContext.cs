using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class ToDoAppContext(DbContextOptions<ToDoAppContext> options) : DbContext(options)
    {
        public DbSet<Note> Notes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Note>().HasKey(x => x.Id);
            modelBuilder.Entity<Note>().Property(x => x.Title).HasMaxLength(50);
            modelBuilder.Entity<Note>().Property(x => x.Description).HasMaxLength(150);
            base.OnModelCreating(modelBuilder);
        }
    }
}
