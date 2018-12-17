using System;
using System.Collections.Generic;

namespace ProjetLibrary.Business.RestaurantDinerRoom.DinerRoom
{
	public class Buttler {
		
        public List<Table.TableStatus> GetTableStatus(List<Table.TableStatus> tableList)
        {
            List<Table.TableStatus> statusAllTable = null;
            for (int i = 0; i < tableList.Count; i++)
            {
                statusAllTable[i] = tableList[i];
            }
            return statusAllTable;
        }

		public int GetCustomerGroupNumber(CustomerGroup customerGroup)
        {
            return customerGroup.GroupNumber;
        }

		public void TableAttribution()
        {
            Console.WriteLine("Le Maitre d'hotel attribue une table aux clients");
		}

		public void CallHeadWaiter() {
			throw new System.Exception("Not implemented");
		}
		private Person person;
	}

}
