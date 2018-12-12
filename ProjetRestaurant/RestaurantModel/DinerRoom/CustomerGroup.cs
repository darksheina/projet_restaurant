using System;
<<<<<<< HEAD
using System.Threading;
=======
using System.Collections.Generic;
>>>>>>> refs/remotes/origin/Alexis'BranchRenouveau

namespace RestaurationModel.DinerRoom
{
	public class CustomerGroup {
		public int GroupNumber;
<<<<<<< HEAD
	//	public List<Model.Kitchen.Food> GroupOrder;
		public int IDTable;
		public int GroupID;
	//	public EatStrategy EatStrategy;
=======
		public List<Kitchen.Food> GroupOrder;
		public int IDTable;
		public int GroupID;
		public EatStategy eatStrategy;
>>>>>>> refs/remotes/origin/Alexis'BranchRenouveau

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
<<<<<<< HEAD
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

=======
		public List<Kitchen.Food> GetGroupOrder() {
            return this.GroupOrder;
		}
		public void SetGroupOrder(List<Kitchen.Food> groupOrder) {
            this.GroupOrder = groupOrder;
		}

		private EatStategy eatStategy;
		private Person person;
>>>>>>> refs/remotes/origin/Alexis'BranchRenouveau
	}

}
