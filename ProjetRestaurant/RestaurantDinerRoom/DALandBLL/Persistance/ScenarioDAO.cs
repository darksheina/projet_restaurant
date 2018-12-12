using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantDinerRoom.DALandBLL.Persistance
{
	public class ScenarioDAO {
		public int ID { get; set; }
        public string Description { get; set; }
        public int OrderStage { get; set; }
        public int ID_type_scenario { get; set; }
        [ForeignKey ("ID_type_scenario")]
        public virtual TypeScenarioDAO ScenarioType { get; set; }
        public int ID_action { get; set; }
        [ForeignKey ("ID_action")]
        public virtual ActionDAO Action { get; set; }
    }

}
