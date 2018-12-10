using Microsoft.EntityFrameworkCore;
using System;
namespace RestaurationModel.DALandBLL.Persistance
{
	public class DatabaseContext : DbContext {
	
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        public DbSet<ActionDAO> Action;
        public DbSet<RoleDAO> Role;
        public DbSet<ScenarioDAO> Scenario;
        public DbSet<ScenarioTypeDAO> ScenarioType;


    }

}
