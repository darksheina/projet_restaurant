using RestaurationModel.DALandBLL.Business;
using RestaurationModel.DALandBLL.Mapper;
using RestaurationModel.DALandBLL.Persistance;
using System;
namespace RestaurationModel.DALandBLL.Service
{
    public class ScenarioTypeService
    {
        DatabaseContext context;

        public ScenarioTypeService()
        {
            context = new DatabaseContext();
        }
        public void Add(ScenarioTypeBusiness scenarioType)
        {
            var entity = ScenarioTypeMapper.Map(scenarioType);
            context.ScenarioType.Add(entity);
            context.SaveChanges();
        }
        public void Delete(ScenarioTypeBusiness scenarioType)
        {
            var entity = context.ScenarioType.Find(scenarioType.ID);
            if (entity != null)
            {
                context.ScenarioType.Remove(entity);
                context.SaveChanges();
            }
        }
        public void Get(string name)
        {
            //ToDo
        }
        public void Update(ScenarioTypeBusiness scenarioType)
        {
            var entity = context.ScenarioType.Find(scenarioType.ID);
            if (entity != null)
            {
                entity.Entitled = scenarioType.Entitled;
                context.SaveChanges();
            }
        }

    }
}

