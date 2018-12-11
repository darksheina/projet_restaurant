using Microsoft.EntityFrameworkCore;
using System;
namespace RestaurationModel.DALandBLL.Persistance
{
	public class DatabaseContext : DbContext {
	
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           //optionsBuilder.UseSqlServer(@"Data Source=217.182.91.216,1433;Initial Catalog=Restaurant;User ID=SA;Password=***********");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RefersToDAO>().HasKey(vf => new { vf.Role, vf.Action });
        }

        public DbSet<ActionDAO> Action;
        public DbSet<RoleDAO> Role;
        public DbSet<ScenarioDAO> Scenario;
        public DbSet<ScenarioTypeDAO> ScenarioType;
        public DbSet<RefersToDAO> RefersTo;


    }

}
