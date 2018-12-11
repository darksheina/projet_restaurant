using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurationModel.DALandBLL.Persistance
{
	public class ScenarioDAO {
		public int ID { get; set; }
        public string Description { get; set; }
        public int Order { get; set; }
        public int ScenarioTypeID { get; set; }
        [ForeignKey ("ScenarioTypeID")]
        public virtual ScenarioTypeDAO ScenarioType { get; set; }
        public int ActionID { get; set; }
        [ForeignKey ("ActionID")]
        public virtual ActionDAO Action { get; set; }
    }

}
