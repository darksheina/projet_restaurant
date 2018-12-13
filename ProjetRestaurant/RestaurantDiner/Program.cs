using ProjectLibrary.Business;
using ProjectLibrary.Service;
using ProjetLibrary.Business.RestaurantDinerRoom;
using RestaurantDinerRoom.DALandBLL.Service;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace RestaurantDiner
{
    class Program
    {
        static void Main(string[] args)
        {
            Scenario scenario;
            scenario = new Scenario();
            scenario.ExecuteScenario();


        }
    }
}
