using RestaurationModel.DALandBLL.Business;
using RestaurationModel.DALandBLL.Mapper;
using RestaurationModel.DALandBLL.Persistance;
using System;
namespace RestaurationModel.DALandBLL.Service
{
	public class RoleService {
        DatabaseContext context;

        public RoleService()
        {
            context = new DatabaseContext();
        }
        public void Add(RoleBusiness role) {
            var entity = RoleMapper.Map(role);
            context.Role.Add(entity);
            context.SaveChanges();
		}
		public void Delete(RoleBusiness role) {
            var entity = context.Role.Find(role.ID);
            if (entity != null)
            {
                context.Role.Remove(entity);
                context.SaveChanges();
            }
		}
		public void Get(string name) {
			//ToDo
		}
		public void Update(RoleBusiness role) {
            var entity = context.Role.Find(role.ID);
            if(entity != null)
            {
                entity.Entitled = role.Entitled;
                context.SaveChanges();
            }
		}

		

	}

}
