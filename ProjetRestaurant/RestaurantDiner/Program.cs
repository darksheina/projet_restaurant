using ProjectLibrary.Business;
using RestaurantDinerRoom.DALandBLL.Service;
using System;
using System.Collections.Generic;

namespace RestaurantDiner
{
    class Program
    {
        static void Main(string[] args)
        {
            RoleService roleservice;
            roleservice = new RoleService();
            List<RoleBusiness> plop2 = roleservice.Select();
            foreach (var item in plop2)
            {
                Console.WriteLine("Nom du rôle : " + item.Entitled);
            }
        }
    }
}
