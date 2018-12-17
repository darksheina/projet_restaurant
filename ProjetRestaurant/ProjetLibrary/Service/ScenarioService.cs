using System;
using System.Linq;
using System.Collections.Generic;
using ProjetLibrary.Persistance;
using ProjetLibrary.Business;
using ProjetLibrary.Mapper;

namespace ProjetLibrary.Service
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

        //Get by id
        public ScenarioBusiness Get(int id)
        {
            var result = ScenarioMapper.Map((from p in context.Scenario where p.ID == id select p).FirstOrDefault());
            return result;
        }

        public List<ScenarioBusiness> GetScenarioLines(int id)
        {
            return ScenarioMapper.Map((from p in context.Scenario where p.ID_type_scenario == id select p ).ToList());
        }

    }

}
