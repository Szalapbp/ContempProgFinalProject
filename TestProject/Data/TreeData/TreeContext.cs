using Microsoft.EntityFrameworkCore;
using ContempProgFinalProject.Models;

namespace ContempProgFinalProject.Data.TreeData
{
    public class TreeContext : DbContext
    {
        public TreeContext(DbContextOptions<TreeContext> options) :
            base(options)
        { }
        public DbSet<Tree> Tree { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tree>().HasData(
            new Tree { Id = 1, Type = "Fur", Price = 150m, Height = 2, Age = 7 },
            new Tree { Id = 2, Type = "Great Oak", Price = 175m, Height = 2, Age = 6 }
            );

        }
    }
}
