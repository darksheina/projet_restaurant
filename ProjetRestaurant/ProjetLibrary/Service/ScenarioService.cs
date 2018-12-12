using System;
using System.Linq;
using System.Collections.Generic;
using ProjectLibrary.Business;
using ProjectLibrary.Mapper;
using ProjetLibrary.Persistance;

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
        public ScenarioBusiness Get(int id) {
            var result = ScenarioMapper.Map((from p in context.Scenario where p.ID == id select p).FirstOrDefault());
            Console.WriteLine("Result = {0}", result.ScenarioType); //Test Console
            return result;
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
            return ScenarioMapper.Map((from p in context.Scenario select p).ToList());
        }
    }

}
