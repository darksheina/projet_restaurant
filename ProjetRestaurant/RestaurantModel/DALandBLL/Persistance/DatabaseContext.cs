using Microsoft.EntityFrameworkCore;
using System;
namespace RestaurationModel.DALandBLL.Persistance
{
	public class DatabaseContext : DbContext {
	
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer(@"Data Source=217.182.91.216,1433;Initial Catalog=Restaurant;User ID=SA;Password=Exi@2018");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RoleActionDAO>().HasKey(vf => new { vf.ID_role, vf.ID_action });
        }

        public DbSet<ActionDAO> Action { get; set; }
        public DbSet<RoleDAO> Role { get; set; }
        public DbSet<ScenarioDAO> Scenario { get; set; }
        public DbSet<TypeScenarioDAO> TypeScenario { get; set; }
        public DbSet<RoleActionDAO> RefersTo { get; set; }


    }

}
