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
		public void SetGroupNumber()
        {
            Random rnd = new Random();
            int groupNumber = rnd.Next(1, 9);
            Console.WriteLine(groupNumber);
            this.GroupNumber = groupNumber;
        }
		public int GetGroupID() {
			return this.GroupID;
		}
		public void SetGroupID(int groupID) {
			this.GroupID = groupID;
		}
//		public void<Model.Kitchen.Food> GetGroupOrder() {
//			throw new System.Exception("Not implemented");
//		}
//		public void SetGroupOrder(object<Model.Kitchen.Food> groupOrder) {
//			throw new System.Exception("Not implemented");
//		}

        public void ChooseOrder()
        {
            // TODO : modifier ?
            // Le client choisi son plat, il met au moins 5 min
            Console.WriteLine("CustomerGroup : Il nous faut au moins 5 min pour choisir nos plats !!"); // TODO : a enlever --> log
            Thread.Sleep(5000); //wait 5sec for choose order
            Console.WriteLine("CustomerGroup : Nous avons choisi nos plats !!"); // TODO : a enlever --> log
        }

		private EatStategy eatStategy;

		// private Person person;

	}

}
