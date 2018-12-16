using ProjectLibrary.Business;
using ProjetLibrary.Business.RestaurantDinerRoom;
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
