using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterChefInfo
{
    /// <summary>
    /// La classe permet de présenter un scénario afin de tester un service en continu du restaurant
    /// </summary>
    class ScenarioController
    {
        readonly Random rnd = new Random();
        Thread threadScenario;
        Model model;
        ClientGeneratorController clientGeneratorController;

        public ScenarioController(Model model)
        {
            this.model = model;
            clientGeneratorController = new ClientGeneratorController(model);
            threadScenario = new Thread(new ThreadStart(ScenarioLoop));
            threadScenario.Start();
        }

        public void NewGroupClient()
        {
            model.dinnerRoom.waitingGroupClients.Add(clientGeneratorController.CreateNewGroupClient());
        }

        /// <summary>
        /// La méthode permet de créer un groupe de client toutes les 0 à 5 minutes
        /// </summary>
        public void ScenarioLoop()
        {
            while (Thread.CurrentThread.IsAlive)
            {
                int randomNumber = rnd.Next(0, 5);
                Thread.Sleep(randomNumber * 3000);
                NewGroupClient();
            }
        }

    }
}
