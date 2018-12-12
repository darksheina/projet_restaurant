using RestaurationModel.DALandBLL.Persistance;
using System;
namespace RestaurantDinerRoom.DALandBLL.Business
{
	public class ScenarioBusiness {
		public int ID { get; set; }
		public string Description { get; set; }
		public int OrderStage { get; set; }
		public TypeScenarioBusiness ScenarioType { get; set; }
		public ActionBusiness Action { get; set; } 

	}

}
