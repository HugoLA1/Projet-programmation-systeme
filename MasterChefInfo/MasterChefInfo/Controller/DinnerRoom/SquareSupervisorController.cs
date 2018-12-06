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
    /// La classe permettant de controler les Square supervisor
    /// </summary>
    class SquareSupervisorController
    {
        public SquareSupervisor GetSquareSupervisor(Square square)
        {
            return new SquareSupervisor();
        }

        Model model;
        Thread threadS;
        GroupClientController groupClientController;

        public SquareSupervisorController(Model model, GroupClientController groupClientController)
        {
            this.model = model;
            this.groupClientController = groupClientController;
            CreateThread();
        }

        /// <summary>
        /// Créer un thread
        /// </summary>
        public void CreateThread()
        {
            threadS = new Thread(new ThreadStart(WatchLoop));
            threadS.Start();
        }

        /// <summary>
        /// Surveille les variations des états et lance la méthode adapté en fonction (Ici : Donner menus et les récupérer)
        /// </summary>
        public void WatchLoop()
        {
            while (Thread.CurrentThread.IsAlive)
            {
                bool getOutOfLoop = false;
                for (int s = 0; s < model.dinnerRoom.squares.Count; s++)
                {
                    if (model.dinnerRoom.squares[s].squareSupervisor.isAvailable)
                    {
                        for (int l = 0; l < model.dinnerRoom.squares[s].lines.Count; l++)
                        {
                            for (int t = 0; t < model.dinnerRoom.squares[s].lines[l].tables.Count; t++)
                            {
                                if(model.dinnerRoom.squares[s].lines[l].tables[t].groupClient != null)
                                {
                                    switch (model.dinnerRoom.squares[s].lines[l].tables[t].groupClient.dishState)
                                    {
                                        case DishState.WaitMenu:
                                            model.dinnerRoom.squares[s].squareSupervisor.isAvailable = false;
                                            Thread threadSM = new Thread(() => SearchMenu(model.dinnerRoom.squares[s].lines[l].tables[t], model.dinnerRoom.squares[s].squareSupervisor));
                                            MessageBox.Show("Un groupe attend son menu (5)");
                                            getOutOfLoop = true;
                                            threadSM.Start();
                                            break;
                                        case DishState.Choosed:
                                            model.dinnerRoom.squares[s].squareSupervisor.isAvailable = false;
                                            Thread threadCM = new Thread(() => CollectMenu(model.dinnerRoom.squares[s].lines[l].tables[t], model.dinnerRoom.squares[s].squareSupervisor));
                                            getOutOfLoop = true;
                                            threadCM.Start();
                                            break;
                                        case DishState.WaitToBePlaced:
                                            model.dinnerRoom.squares[s].squareSupervisor.isAvailable = false;
                                            Thread threadEC = new Thread(() => EscortClient(model.dinnerRoom.squares[s].lines[l].tables[t].groupClient, model.dinnerRoom.squares[s].squareSupervisor));
                                            MessageBox.Show("Un groupe va etre placer a sa table (4)");
                                            getOutOfLoop = true;
                                            threadEC.Start();
                                            break;
                                    }
                                }
                                if (getOutOfLoop) break;
                            }
                            if (getOutOfLoop) break;

                        }
                        if (getOutOfLoop) break;
                    }
                }
                Thread.Sleep(100);
            }
        }
        /// <summary>
        /// Méthode permettant d'amener les clients aux tables
        /// </summary>
        public void EscortClient(GroupClient groupClient, SquareSupervisor squareSupervisor)
        {
            bool getOutOfLoop = false;
            for (int s = 0; s < model.dinnerRoom.squares.Count; s++)
            {
                    for (int l = 0; l < model.dinnerRoom.squares[s].lines.Count; l++)
                    {
                        for (int t = 0; t < model.dinnerRoom.squares[s].lines[l].tables.Count; t++)
                        {
                            if (model.dinnerRoom.squares[s].lines[l].tables[t].groupClient == groupClient)
                            {
                                MoveToTable(model.dinnerRoom.squares[s].lines[l].tables[t], model.dinnerRoom.squares[s].squareSupervisor);
                                model.dinnerRoom.squares[s].lines[l].tables[t].groupClient.dishState = DishState.WaitMenu;
                                Thread.Sleep(2000);
                                MoveToWelcome(squareSupervisor);
                                squareSupervisor.isAvailable = true;
                                getOutOfLoop = true;
                            }
                        if (getOutOfLoop) break;
                    }
                        if (getOutOfLoop) break;
                    }
                
                if (getOutOfLoop) break;
            }
        }

        /// <summary>
        /// Méthode permettant de faire bouger le personnage en fonction de la classe Clock
        /// </summary>
        public void MoveToTable(Table table, SquareSupervisor squareSupervisor)
        {

        }

        /// <summary>
        /// Méthode pour aller récupérer les menus et les amener aux clients
        /// </summary>
        public void SearchMenu (Table table, SquareSupervisor squareSupervisor)
        {
            MoveToTable(table, squareSupervisor);
            table.groupClient.dishState = DishState.Choosing;
            groupClientController.ThreadChoseMenu(table.groupClient);
            table.menus = table.groupClient.clientNumber;
            MessageBox.Show("Un groupe vient de recevoir un menu (6)");
            Thread.Sleep(2000);
            MoveToWelcome(squareSupervisor);
            squareSupervisor.isAvailable = true;
        }

        /// <summary>
        /// Méthode permettant de se déplacer à l'accueil
        /// </summary>
        private void MoveToWelcome(SquareSupervisor squareSupervisor)
        {
            
        }

        /// <summary>
        /// Méthode pour aller récupérer les menus des clients et prendre leur commande en même temps
        /// </summary>
        public void CollectMenu(Table table, SquareSupervisor squareSupervisor)
        {
            MoveToTable(table, squareSupervisor);
            table.groupClient.dishState = DishState.WaitBreadAndWater;
            table.menus = 0;
            MessageBox.Show("Un groupe vient de choisir son entrée(7)");
            GetCommande(table, squareSupervisor);
            Thread.Sleep(2000);
            MoveToWelcome(squareSupervisor);
            squareSupervisor.isAvailable = true;
        }
        /// <summary>
        /// Méthode pour récuperer la commande des clients
        /// </summary>
        public void GetCommande(Table table, SquareSupervisor squareSupervisor)
        {
            model.counter.waitingGroupCommand.Add(new GroupCommand(table.groupClient.clientNumber, table));
            foreach (Client client in table.groupClient.clients)
            {
                model.kitchen.cookingRoom.masterChef.commandsToDo.Add(client.appetizer);
            }
            Thread.Sleep(2000);
            MessageBox.Show("Commande entrée prise(8)");
            MoveToWelcome(squareSupervisor);
            squareSupervisor.isAvailable = true;
        }
    }
}
