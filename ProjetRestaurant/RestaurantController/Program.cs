using RestaurationModel.DALandBLL.Business;
using RestaurationModel.DALandBLL.Service;
using System;
using System.Collections.Generic;

namespace RestaurantController
{
    class Program
    {
        static void Main(string[] args)
        {
            RoleService roleservice;
            roleservice = new RoleService();
            List<RoleBusiness> plop2 = roleservice.Select();
            foreach(var item in plop2)
            {
                Console.WriteLine("Nom du rôle : " + item.Entitled );
            }

            ActionService actionservice;
            actionservice = new ActionService();
            List<ActionBusiness> plop3 = actionservice.Select();
            foreach (var item in plop3)
            {
                Console.WriteLine("\nNom de l'action : " + item.Entitled+"\nMethode à laquelle on fait reference :"+item.MethodRef);
            }

            TypeScenarioService typescenarioservice;
            typescenarioservice = new TypeScenarioService();
            List<TypeScenarioBusiness> plop4 = typescenarioservice.Select();
            foreach (var item in plop4)
            {
                Console.WriteLine("Nom du type de Scénario : " + item.Entitled);
            }
            /*ScenarioService scenarioService;
            scenarioService = new ScenarioService();
            List<ScenarioBusiness> plop = scenarioService.Select();
             foreach (var item in plop)
            {
                Console.WriteLine("Description : " + item.Description + "Ordre d'execution : " + item.Order+ "Le type de scenario :"+ item.ScenarioType.Entitled+"Action"+item.Action.Entitled);
            }*/
            Console.Read();
        }
    }
}
