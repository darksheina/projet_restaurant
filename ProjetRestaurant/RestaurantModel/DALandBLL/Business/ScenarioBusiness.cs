using System;
namespace RestaurationModel.DALandBLL.Business
{
	public class ScenarioBusiness {
		public int ID;
		public string Name;
		public string Description;
		public int Order;
		public Persistance.ScenarioTypeDAO ScenarioTypeID;
		public Persistance.ActionDAO ActionID;

	}

}
