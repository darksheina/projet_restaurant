using System;
using System.Linq;
using System.Collections.Generic;
using ProjectLibrary.Persistance;
using ProjectLibrary.Business;
using ProjectLibrary.Mapper;

namespace ProjectLibrary.Service
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
            ScenarioBusiness scenario;
            scenario = new ScenarioBusiness();
            name = scenario.Description;
            var entity = context.Scenario.Find(scenario.Description);
            Console.WriteLine("Description :"+ entity.Description+"OrderStage :"+ entity.OrderStage);
            Console.Read();
        }
        public void Update(ScenarioBusiness scenario) {
            var entity = context.Scenario.Find(scenario.ID);
            if (entity != null)
            {
                entity.Description = scenario.Description;
                entity.OrderStage = scenario.OrderStage;
                //ToDo TypeScenario and Action
                context.SaveChanges();
            }
        }

        public List<ScenarioBusiness> Select()
        {
            throw new NotImplementedException();
            //return (from p in context.Scenario.Include(i=>i.Action).Include(i=>i.ScenarioType)
                    //select ScenarioMapper.Map(p)).ToList();
        }
    }

}
