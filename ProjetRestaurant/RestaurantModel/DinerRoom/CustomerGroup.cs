using RestaurationModel.Kitchen;
using System;
using System.Collections.Generic;

namespace RestaurationModel.DinerRoom
{
	public class CustomerGroup {
        private int groupNumber;
        private List<Food> groupOrder;
        private int iDTable;
        private int groupID;
        private EatStategy eatStrategy;

        public void AskBread() {
			throw new System.Exception("Not implemented");
		}
		public void AskWater() {
			throw new System.Exception("Not implemented");
		}
		public void Eat() {
			throw new System.Exception("Not implemented");
		}

        public int GroupNumber { get => groupNumber; set => groupNumber = value; }
        public List<Food> GroupOrder { get => groupOrder; set => groupOrder = value; }
        public int IDTable { get => iDTable; set => iDTable = value; }
        public int GroupID { get => groupID; set => groupID = value; }
        public EatStategy EatStrategy { get => eatStrategy; set => eatStrategy = value; }




    }

}
