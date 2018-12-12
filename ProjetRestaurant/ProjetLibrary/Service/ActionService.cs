using ProjectLibrary.Business;
using ProjectLibrary.Mapper;
using ProjetLibrary.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectLibrary.Service
{
    public class ActionService {

        DatabaseContext context;

        public ActionService()
        {
            context = new DatabaseContext();
        }
		public void Add(ActionBusiness action) {
            var entity = ActionMapper.Map(action);
            context.Action.Add(entity);
            context.SaveChanges();
			
		}
		public void Delete(ActionBusiness action) {
            var entity = context.Action.Find(action.ID);
            if (entity != null)
            {
                context.Action.Remove(entity);
                context.SaveChanges();
            }
			
		}
        //Get by Id
        /*public ActionBusiness Get(int id) {
            var result = ActionMapper.Map((from p in context.Action where p.ID == id select p).FirstOrDefault());
            Console.WriteLine("Result = {0}", result.Entitled); //Test Console
            return result;
        }*/

            // Get by action title
        public ActionBusiness Get(string name)
        {
            var result = ActionMapper.Map((from p in context.Action where p.Entitled == name select p).FirstOrDefault());
            return result;
        }

        public void Update(ActionBusiness action) {
            var entity = context.Action.Find(action.ID);
            if (entity != null)
            {
                entity.Entitled = action.Entitled;
                entity.MethodRef = action.MethodRef;
                context.SaveChanges();
            }
			
		}
        public List<ActionBusiness> Select()
        {
            return ActionMapper.Map((from p in context.Action select p).ToList());
        }



    }

}
