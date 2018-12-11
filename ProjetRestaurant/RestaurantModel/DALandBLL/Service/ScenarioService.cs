using Microsoft.EntityFrameworkCore;
using RestaurationModel.DALandBLL.Business;
using RestaurationModel.DALandBLL.Mapper;
using RestaurationModel.DALandBLL.Persistance;
using System;
using System.Linq;
using System.Collections.Generic;

namespace RestaurationModel.DALandBLL.Service
{
	public class ScenarioService {
        DatabaseContext context;

        public ScenarioService()
        {
            context = new DatabaseContext();
        }
        public void Add(ScenarioBusiness scenario) {
            var entity = ScenarioMapper.Map(scenario);
            context.Scenario.Add(entity);
            context.SaveChanges();
        }
		public void Delete(ScenarioBusiness scenario) {
            var entity = context.Scenario.Find(scenario.ID);
            if (entity != null)
            {
                context.Scenario.Remove(entity);
                context.SaveChanges();
            }
        }
		public void Get(string name) {
			//ToDo
		}
		public void Update(ScenarioBusiness scenario) {
            var entity = context.Scenario.Find(scenario.ID);
            if (entity != null)
            {
                entity.Description = scenario.Description;
                entity.Order = scenario.Order;
                //ToDo TypeScenario and Action
                context.SaveChanges();
            }
        }

        public List<ScenarioBusiness> Select()
        {
            return (from p in context.Scenario.Include(i=>i.Action).Include(i=>i.ScenarioType)
                    select ScenarioMapper.Map(p)).ToList();
        }
    }

}
