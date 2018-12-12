
using ProjectLibrary.Business;
using System.Collections.Generic;
using System.Linq;

namespace ProjectLibrary.Mapper
{
    public class TypeScenarioMapper
    {
        public static TypeScenarioBusiness Map(ProjetLibrary.Persistance.TypeScenario scenarioType)
        {
            return new TypeScenarioBusiness
            {
                ID = scenarioType.ID,
                Entitled = scenarioType.Entitled,
            };
        }
        public static ProjetLibrary.Persistance.TypeScenario Map(TypeScenarioBusiness scenarioType)
        {
            return new ProjetLibrary.Persistance.TypeScenario
            {
                ID = scenarioType.ID,
                Entitled = scenarioType.Entitled,
            };
        }

        public static List<TypeScenarioBusiness> Map(List<ProjetLibrary.Persistance.TypeScenario> scenarioTypes)
        {
            return (from v in scenarioTypes select Map(v)).ToList();

        }

    }
}
