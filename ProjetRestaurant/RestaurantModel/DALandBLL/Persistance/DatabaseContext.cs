using Microsoft.EntityFrameworkCore;
using System;
namespace RestaurationModel.DALandBLL.Persistance
{
	public class DatabaseContext : DbContext {
	
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=217.182.91.216,1433;User ID=SA;Database=a45d1a057fb1.Restaurant.dbo;Password=Exi@2018;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        public DbSet<ActionDAO> Action;
        public DbSet<RoleDAO> Role;
        public DbSet<ScenarioDAO> Scenario;
        public DbSet<ScenarioTypeDAO> ScenarioType;
        public DbSet<RefersToDAO> RefersTo;


    }

}
