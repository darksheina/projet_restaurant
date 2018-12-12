using ProjectLibrary.Business;
using ProjectLibrary.Mapper;
using ProjectLibrary.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectLibrary.Service
{
    public class TypeScenarioService
    {
        DatabaseContext context;

        public TypeScenarioService()
        {
            context = new DatabaseContext();
        }
        public void Add(TypeScenarioBusiness scenarioType)
        {
            var entity = TypeScenarioMapper.Map(scenarioType);
            context.TypeScenario.Add(entity);
            context.SaveChanges();
        }
        public void Delete(TypeScenarioBusiness scenarioType)
        {
            var entity = context.TypeScenario.Find(scenarioType.ID);
            if (entity != null)
            {
                context.TypeScenario.Remove(entity);
                context.SaveChanges();
            }
        }
        public TypeScenarioBusiness Get(int id)
        {

            return (from p in context.TypeScenario where p.ID == id select TypeScenarioMapper.Map(p)).FirstOrDefault();
        }
        public void Update(TypeScenarioBusiness scenarioType)
        {
            var entity = context.TypeScenario.Find(scenarioType.ID);
            if (entity != null)
            {
                entity.Entitled = scenarioType.Entitled;
                context.SaveChanges();
            }
        }
        public List<TypeScenarioBusiness> Select()
        {
            return (from p in context.TypeScenario select TypeScenarioMapper.Map(p)).ToList();
        }

    }
}

