using System;
using System.Collections.Generic;

namespace RestaurationModel.DinerRoom
{
	public class CustomerGroup {
		public int GroupNumber;
		public List<Kitchen.Food> GroupOrder;
		public int IDTable;
		public int GroupID;
		public EatStategy eatStrategy;

		public void AskBread() {
		}
		public void AskWater() {
			throw new System.Exception("Not implemented");
		}
		public void Eat() {
			throw new System.Exception("Not implemented");
		}
		public int GetGroupNumber() {
			return this.GroupNumber;
		}
		public void SetGroupNumber(int groupNumber) {
			this.GroupNumber = groupNumber;
		}
		public int GetGroupID() {
			return this.GroupID;
		}
		public void SetGroupID(int groupID) {
			this.GroupID = groupID;
		}
		public List<Kitchen.Food> GetGroupOrder() {
            return this.GroupOrder;
		}
		public void SetGroupOrder(List<Kitchen.Food> groupOrder) {
            this.GroupOrder = groupOrder;
		}

		private EatStategy eatStategy;
		private Person person;
	}

}
