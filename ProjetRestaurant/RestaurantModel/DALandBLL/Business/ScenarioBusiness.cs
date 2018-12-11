using RestaurationModel.DALandBLL.Persistance;
using System;
namespace RestaurationModel.DALandBLL.Business
{
	public class ScenarioBusiness {
		public int ID { get; set; }
		public string Description { get; set; }
		public int Order { get; set; }
		public ScenarioTypeBusiness ScenarioType { get; set; }
		public ActionBusiness Action { get; set; } 

	}

}
