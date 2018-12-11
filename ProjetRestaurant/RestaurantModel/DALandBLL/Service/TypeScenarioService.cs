using RestaurationModel.DALandBLL.Business;
using RestaurationModel.DALandBLL.Mapper;
using RestaurationModel.DALandBLL.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestaurationModel.DALandBLL.Service
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
        public void Get(string name)
        {
            //ToDo
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

