using RestaurationModel.DALandBLL.Business;
using RestaurationModel.DALandBLL.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurationModel.DALandBLL.Mapper
{
	public class ScenarioMapper {
		public static ScenarioBusiness Map(ScenarioDAO scenario) {
            return new ScenarioBusiness
            {
                ID = scenario.ID,
                Description = scenario.Description,
                Order = scenario.Order,
                Action = scenario.Action != null ? ActionMapper.Map(scenario.Action) : null,
                ScenarioType = scenario.ScenarioType != null ? TypeScenarioMapper.Map(scenario.ScenarioType): null,
            };
		}
		public static ScenarioDAO Map(ScenarioBusiness scenario) {
            return new ScenarioDAO
            {
                ID = scenario.ID,
                Description = scenario.Description,
                Order = scenario.Order,
                Action = scenario.Action != null ? ActionMapper.Map(scenario.Action) : null,
                ScenarioType = scenario.ScenarioType != null ? TypeScenarioMapper.Map(scenario.ScenarioType) : null,
            };
		}
		public static List<ScenarioBusiness> Map(List<ScenarioDAO> scenarios) {
            return (from v in scenarios select Map(v)).ToList();
		}

        internal static object Map(RoleDAO p)
        {
            throw new NotImplementedException();
        }
    }

}
