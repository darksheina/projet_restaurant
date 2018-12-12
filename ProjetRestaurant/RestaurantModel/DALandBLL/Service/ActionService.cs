using RestaurationModel.DALandBLL.Business;
using RestaurationModel.DALandBLL.Mapper;
using RestaurationModel.DALandBLL.Persistance;
using System;
namespace RestaurationModel.DALandBLL.Service {
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
		public void Get(string name) {
			//ToDo
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

		

	}

}
