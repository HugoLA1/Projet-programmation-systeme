using System;
using System.Collections.Generic;
using System.Drawing;
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
                /*if(model.dinnerRoom.squares[0].lines[0].tables[0].groupClient != null)
                {
                    Console.WriteLine(Convert.ToString(model.dinnerRoom.squares[0].lines[0].tables[0].groupClient.dishState));
                }*/
                bool getOutOfLoop = false;
                foreach (Square square in model.dinnerRoom.squares)
                {
                    if (square.squareSupervisor.isAvailable)
                    {
                        foreach (Line line in square.lines)
                        {
                            foreach (Table table in line.tables)
                            {
                                if(table.groupClient != null)
                                {
                                    switch (table.groupClient.dishState)
                                    {
                                        case DishState.WaitMenu:
                                            square.squareSupervisor.isAvailable = false;
                                            /*ThreadPool.QueueUserWorkItem(
                                              new WaitCallback(delegate (object state)
                                              { SearchMenu(table, square.squareSupervisor); }), null);*/
                                            Task threadSM = new Task(() => SearchMenu(table, square.squareSupervisor));
                                            getOutOfLoop = true;
                                            //threadSM.Name = "threadSM";
                                            threadSM.Start();
                                            break;
                                        case DishState.Choosed:
                                            square.squareSupervisor.isAvailable = false;
                                            /*ThreadPool.QueueUserWorkItem(
                                              new WaitCallback(delegate (object state)
                                              { CollectMenu(table, square.squareSupervisor); }), null);*/
                                            Task threadCM = new Task(() => CollectMenu(table, square.squareSupervisor));
                                            getOutOfLoop = true;
                                            threadCM.Start();
                                            break;
                                        case DishState.WaitToBePlaced:
                                            square.squareSupervisor.isAvailable = false;
                                            /*ThreadPool.QueueUserWorkItem(
                                              new WaitCallback(delegate (object state)
                                              { EscortClient(table, square.squareSupervisor); }), null);    */                                       
                                            Task threadEC = new Task(() => EscortClient(table,square.squareSupervisor));
                                            getOutOfLoop = true;
                                            //threadEC.Name = "threadEC";
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
                    if (getOutOfLoop) break;
                }
                Thread.Sleep(100);
            }
        }
        /// <summary>
        /// Méthode permettant d'amener les clients aux tables
        /// </summary>
        public void EscortClient(Table table, SquareSupervisor squareSupervisor)
        {
            MoveToTable(table, squareSupervisor);
            table.groupClient.dishState = DishState.WaitMenu;
            MoveToWelcome(table, squareSupervisor);
            squareSupervisor.isAvailable = true;
        }

        /// <summary>
        /// Méthode permettant de faire bouger le personnage en fonction de la classe Clock
        /// </summary>
        public void MoveToTable(Table table, SquareSupervisor squareSupervisor)
        {
            //MessageBox.Show(Thread.CurrentThread.Name);

            squareSupervisor.NotifyObservers(table.supervisorTravelList);
        }

        /// <summary>
        /// Méthode permettant de se déplacer à l'accueil
        /// </summary>
        private void MoveToWelcome(Table table, SquareSupervisor squareSupervisor)
        {
            //MessageBox.Show(Thread.CurrentThread.Name);

            squareSupervisor.NotifyObservers(table.returnSquareList);
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
            MoveToWelcome(table, squareSupervisor);
            squareSupervisor.isAvailable = true;
        }


        /// <summary>
        /// Méthode pour aller récupérer les menus des clients et prendre leur commande en même temps
        /// </summary>
        public void CollectMenu(Table table, SquareSupervisor squareSupervisor)
        {
            MoveToTable(table, squareSupervisor);
            table.groupClient.dishState = DishState.WaitBreadAndWater;
            //MessageBox.Show("WaitBreadAndWater");
            table.menus = 0;
            GetCommande(table, squareSupervisor);
            Thread.Sleep(2000);
            MoveToWelcome(table, squareSupervisor);
            squareSupervisor.isAvailable = true;
        }
        /// <summary>
        /// Méthode pour récuperer la commande des clients
        /// </summary>
        public void GetCommande(Table table, SquareSupervisor squareSupervisor)
        {
            GroupCommand groupCommandTemp = new GroupCommand(table);

            foreach (Client client in table.groupClient.clients)
            {
                client.appetizer.table = table;
                model.kitchen.cookingRoom.masterChef.commandsToDo.Add(client.appetizer);
            }
            Thread.Sleep(2000);

            model.counter.waitingGroupCommand.Add(groupCommandTemp);
            MoveToWelcome(table, squareSupervisor);
            squareSupervisor.isAvailable = true;
        }
    }
}
