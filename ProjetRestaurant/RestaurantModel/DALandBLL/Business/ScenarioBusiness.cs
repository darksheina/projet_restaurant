using RestaurationModel.DALandBLL.Persistance;
using System;
namespace RestaurationModel.DALandBLL.Business
{
	public class ScenarioBusiness {
		public int ID { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public int Order { get; set; }
		public ScenarioTypeBusiness ScenarioTypeID { get; set; }
		public ActionBusiness ActionID { get; set; } 

	}

}
