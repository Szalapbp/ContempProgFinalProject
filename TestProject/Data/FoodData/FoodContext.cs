using Microsoft.EntityFrameworkCore;
using ContempProgFinalProject.Models;

namespace ContempProgFinalProject.Data.FoodData
{
    public class FoodContext : DbContext
    {
        public FoodContext(DbContextOptions<FoodContext> options) :
            base(options)
        { }
        public DbSet<Food> Food { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Food>().HasData(
            new Food { Id = 1, Name = "Apple", Origin = "USA", Price = 0.95m, Quantity = 3 },
            new Food { Id = 2, Name = "Bannana", Origin = "China", Price = 1.25m, Quantity = 6 }
            );

        }
    }
}
