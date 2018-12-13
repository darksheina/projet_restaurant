using ProjectLibrary.Business;
using ProjectLibrary.Mapper;
using ProjetLibrary.Persistance;
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
        //Get by id
        /*public TypeScenarioBusiness Get(int id)
        {
            var result = TypeScenarioMapper.Map((from p in context.TypeScenario where p.ID == id select p).FirstOrDefault());
            Console.WriteLine("Result = {0}",result.Entitled); //Test Console
            return result;
        }*/

        //Get by name
        public TypeScenarioBusiness Get(string name)
        {
            var result = TypeScenarioMapper.Map((from p in context.TypeScenario where p.Entitled == name select p).FirstOrDefault());
            return result;
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
            return TypeScenarioMapper.Map((from p in context.TypeScenario select p).ToList());
        }

    }
}

