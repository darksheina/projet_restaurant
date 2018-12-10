using System;
namespace RestaurationModel.DALandBLL.Persistance
{
	public class ScenarioDAO {
		public int ID;
		public string Name;
		public string Description;
		public int Order;
		public ScenarioTypeDAO ScenarioTypeID;
		public ActionDAO ActionID;

	}

}
