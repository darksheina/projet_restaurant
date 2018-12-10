using RestaurationModel.DALandBLL.Business;
using RestaurationModel.DALandBLL.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestaurationModel.DALandBLL.Mapper
{
    public class ScenarioTypeMapper
    {
        public static ScenarioTypeBusiness Map(ScenarioTypeDAO scenarioType)
        {
            return new ScenarioTypeBusiness
            {
                ID = scenarioType.ID,
                Entitled = scenarioType.Entitled,
            };
        }
        public static ScenarioTypeDAO Map(ScenarioTypeBusiness scenarioType)
        {
            return new ScenarioTypeDAO
            {
                ID = scenarioType.ID,
                Entitled = scenarioType.Entitled,
            };
        }

        public static List<ScenarioTypeBusiness> Map(List<ScenarioTypeDAO> scenarioTypes)
        {
            return (from v in scenarioTypes select Map(v)).ToList();

        }

    }
}
