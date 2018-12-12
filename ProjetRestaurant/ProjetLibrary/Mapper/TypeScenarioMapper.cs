
using ProjectLibrary.Business;
using ProjectLibrary.Persistance;
using System.Collections.Generic;
using System.Linq;

namespace ProjectLibrary.Mapper
{
    public class TypeScenarioMapper
    {
        public static TypeScenarioBusiness Map(TypeScenarioDAO scenarioType)
        {
            return new TypeScenarioBusiness
            {
                ID = scenarioType.ID,
                Entitled = scenarioType.Entitled,
            };
        }
        public static TypeScenarioDAO Map(TypeScenarioBusiness scenarioType)
        {
            return new TypeScenarioDAO
            {
                ID = scenarioType.ID,
                Entitled = scenarioType.Entitled,
            };
        }

        public static List<TypeScenarioBusiness> Map(List<TypeScenarioDAO> scenarioTypes)
        {
            return (from v in scenarioTypes select Map(v)).ToList();

        }

    }
}
