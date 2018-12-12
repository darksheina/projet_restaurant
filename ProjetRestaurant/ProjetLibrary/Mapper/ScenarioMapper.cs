using ProjectLibrary.Business;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectLibrary.Mapper
{
    public class ScenarioMapper {
		public static ScenarioBusiness Map(ProjetLibrary.Persistance.Scenario scenario) {
            return new ScenarioBusiness
            {
                ID = scenario.ID,
                Description = scenario.Description,
                OrderStage = scenario.OrderStage,
                Action = scenario.Action != null ? ActionMapper.Map(scenario.Action) : null,
                ScenarioType = scenario.TypeScenario != null ? TypeScenarioMapper.Map(scenario.TypeScenario): null,
            };
		}
		public static ProjetLibrary.Persistance.Scenario Map(ScenarioBusiness scenario) {
            return new ProjetLibrary.Persistance.Scenario
            {
                ID = scenario.ID,
                Description = scenario.Description,
                OrderStage = scenario.OrderStage,
                Action = scenario.Action != null ? ActionMapper.Map(scenario.Action) : null,
                TypeScenario = scenario.ScenarioType != null ? TypeScenarioMapper.Map(scenario.ScenarioType) : null,
            };
		}
		public static List<ScenarioBusiness> Map(List<ProjetLibrary.Persistance.Scenario> scenarios) {
            return (from v in scenarios select Map(v)).ToList();
		}

        internal static object Map(ProjetLibrary.Persistance.Role p)
        {
            throw new NotImplementedException();
        }
    }

}
