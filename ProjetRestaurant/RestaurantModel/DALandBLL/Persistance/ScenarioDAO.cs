using System;
namespace RestaurationModel.DALandBLL.Persistance
{
	public class ScenarioDAO {
		public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Order { get; set; }
        public ScenarioTypeDAO ScenarioTypeID { get; set; }
        public ActionDAO ActionID { get; set; }

    }

}
