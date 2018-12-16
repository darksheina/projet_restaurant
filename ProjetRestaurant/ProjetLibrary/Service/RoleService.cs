using ProjetLibrary.Business;
using ProjetLibrary.Mapper;
using ProjetLibrary.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetLibrary.Service
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
        //Get avec un id
        /*public RoleBusiness Get(int id) {
            var result = RoleMapper.Map((from p in context.Role where p.ID == id select p).FirstOrDefault());
            Console.WriteLine("Result = {0}", result.Entitled); //Test Console
            return result;
        }*/

        //Get avec un titre
        public RoleBusiness Get(string name)
        {
            var result = RoleMapper.Map((from p in context.Role where p.Entitled == name select p).FirstOrDefault());
            Console.WriteLine("Result = {0}", result.ID); //Test Console
            return result;

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
            return RoleMapper.Map((from p in context.Role select p).ToList());
        }

    }

}
