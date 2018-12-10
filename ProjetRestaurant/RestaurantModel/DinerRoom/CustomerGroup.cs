using System;
namespace RestaurationModel.DinerRoom
{
	public class CustomerGroup {
		public int GroupNumber;
		public List<Model.Kitchen.Food> GroupOrder;
		public int IDTable;
		public int GroupID;
		public EatStrategy EatStrategy;

		public void AskBread() {
			throw new System.Exception("Not implemented");
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
		public void<Model.Kitchen.Food> GetGroupOrder() {
			throw new System.Exception("Not implemented");
		}
		public void SetGroupOrder(object<Model.Kitchen.Food> groupOrder) {
			throw new System.Exception("Not implemented");
		}

		private EatStategy eatStategy;

		private Person person;

	}

}
