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
           
            string oui = "oui";
            Console.WriteLine("Souhaitez-vous voir le contenu des tables : ");
            string saisie = Console.ReadLine();
            if(String.Compare(oui, saisie) == 0)
            {
                RoleService roleservice;
                roleservice = new RoleService();
                List<RoleBusiness> plop2 = roleservice.Select();
                foreach (var item in plop2)
                {
                    Console.WriteLine("Nom du rôle : " + item.Entitled);
                }

                ActionService actionservice;
                actionservice = new ActionService();
                List<ActionBusiness> plop3 = actionservice.Select();
                foreach (var item in plop3)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Nom de l'action : " + item.Entitled + "\nMethode à laquelle on fait reference :" + item.MethodRef);
                }

                TypeScenarioService typescenarioservice;
                typescenarioservice = new TypeScenarioService();
                List<TypeScenarioBusiness> plop4 = typescenarioservice.Select();
                Console.WriteLine("\n");
                foreach (var item in plop4)
                {
                    Console.WriteLine("Nom du type de Scénario : " + item.Entitled);
                }
                ScenarioService scenarioService;
                scenarioService = new ScenarioService();
                List<ScenarioBusiness> plop = scenarioService.Select();
                Console.WriteLine("\n");
                foreach (var item in plop)
                {

                    Console.WriteLine("Description : " + item.Description + "\nOrdre d'execution : " + item.OrderStage + "\nLe type de scenario :" + item.ScenarioType.Entitled + "Action" + item.Action.Entitled);
                }
                Console.Read();
            }
            else if(String.Compare(saisie, "ajout") == 0)
            {
                RoleBusiness role;
                role = new RoleBusiness();
                Console.WriteLine("Quel role ajouter ? :");
                string text = Console.ReadLine();
                role.Entitled = text;
                RoleService roleservice;
                roleservice = new RoleService();
                roleservice.Add(role);
                Console.WriteLine("Champ ajouter dans la BDD");
                Console.Read();

            }
            else if (String.Compare(saisie, "get") == 0)
            {
                Console.WriteLine("Quel id chercher ? :");
                string text = Console.ReadLine();
                int num = Convert.ToInt32(text);
                TypeScenarioService typeScenarioservice;
                typeScenarioservice = new TypeScenarioService();
                typeScenarioservice.Get(num);
            };


        }

        
    }
}
