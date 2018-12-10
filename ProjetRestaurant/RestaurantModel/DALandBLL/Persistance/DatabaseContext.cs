using Microsoft.EntityFrameworkCore;
using System;
namespace RestaurationModel.DALandBLL.Persistance
{
	public class DatabaseContext {
		public DbSet<RoleDAO> Profession;

		protected void OnConfiguring(DbContextOptionsBuilder optionBuilder) {
			throw new System.Exception("Not implemented");
		}
		protected void OnModelCreating(ModelBuilder modelBuilder) {
			throw new System.Exception("Not implemented");
		}


	}

}
