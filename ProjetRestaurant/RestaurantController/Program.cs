using System;
using System.Collections.Generic;

namespace RestaurantController
{
    class Program
    {
        static void Main(string[] args)
        {
            RestaurationModel.DALandBLL.Service.ScenarioService scenarioService;
            scenarioService = new RestaurationModel.DALandBLL.Service.ScenarioService();
            List<RestaurationModel.DALandBLL.Business.ScenarioBusiness> plop = scenarioService.Select();
             foreach (var item in plop)
            {
                Console.WriteLine("Description : " + item.Description + "Ordre d'execution : " + item.Order+ "Le type de scenario :"+ item.ScenarioType.Entitled+"Action"+item.Action.Entitled);
            }
            Console.Read();
        }
    }
}
