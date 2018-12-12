using ProjectLibrary.Business;
using ProjectLibrary.Mapper;
using ProjectLibrary.Persistance;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantDinerRoom.DALandBLL.Service
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
        public List<RoleBusiness> Select()
        {
            return (from p in context.Role select RoleMapper.Map(p)).ToList();
        }

    }

}
