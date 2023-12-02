using Microsoft.EntityFrameworkCore;
using ContempProgFinalProject.Models;

namespace ContempProgFinalProject.Data.TeamMemberData
{
    public class TeamMemberContext : DbContext
    {
        public TeamMemberContext(DbContextOptions<TeamMemberContext> options) :
            base(options)
        { }
        public DbSet<TeamMembers> Members { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TeamMembers>().HasData(
            new TeamMembers { Id = 1, Name = "Blake Szalapski", Birthdate = "September 5, 2002", CollegeProgram = "IT Game Development and Simulation", CollegeYear = 3 },
            new TeamMembers { Id = 2, Name = "Broderick Widman", Birthdate = "", CollegeProgram = "", CollegeYear = 3 }
            );

        }
    }
}
