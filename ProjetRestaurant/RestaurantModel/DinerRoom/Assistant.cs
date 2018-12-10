using System;
using System.Collections.Generic;

namespace RestaurationModel.DinerRoom {
	public class Assistant {
		private int plateNumberMax = 5;

		public void GetPlateOnCounter(int plateNumberMax) {
			throw new System.Exception("Not implemented");
		}
		public void GiveBread(int iDTable) {
			throw new System.Exception("Not implemented");
		}
		public void GiveWatter(int iDTable) {
			throw new System.Exception("Not implemented");
		}
		public void CleanTable(int iDTable, Table.TableStatus status) {
			throw new System.Exception("Not implemented");
		}
    public void GiveOrders(CustomerGroup customerGroup, int iDTable, List<Kitchen.Food> groupOrders) {
        throw new System.Exception("Not implemented");
    }

	}

}
