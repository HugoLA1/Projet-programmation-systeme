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

        Semaphore threadSMSemaphore;
        Semaphore threadCMSemaphore;
        Semaphore threadECSemaphore;

        public SquareSupervisorController(Model model, GroupClientController groupClientController)
        {
            threadSMSemaphore = new Semaphore(2, 4);
            threadCMSemaphore = new Semaphore(2, 4);
            threadECSemaphore = new Semaphore(2, 4);

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
                    foreach (SquareSupervisor squareSupervisor in square.squareSupervisors)
                    {
                        if (squareSupervisor.isAvailable)
                        {
                            foreach (Line line in square.lines)
                            {
                                foreach (Table table in line.tables)
                                {
                                    if (table.groupClient != null)
                                    {
                                        switch (table.groupClient.dishState)
                                        {
                                            case DishState.WaitMenu:
                                                table.groupClient.dishState = DishState.Choosing;
                                                Console.WriteLine("Apporter le Menu");
                                                squareSupervisor.isAvailable = false;
                                                /*ThreadPool.QueueUserWorkItem(
                                                  new WaitCallback(delegate (object state)
                                                  { SearchMenu(table, square.squareSupervisor); }), null);*/
                                                threadSMSemaphore.WaitOne();
                                                Task threadSM = new Task(() => SearchMenu(table, squareSupervisor));
                                                getOutOfLoop = true;
                                                //threadSM.Name = "threadSM";
                                                threadSM.Start();
                                                break;
                                            case DishState.Choosed:
                                                table.groupClient.dishState = DishState.WaitBreadAndWater;
                                                Console.WriteLine("Récupérer les commandes");
                                                squareSupervisor.isAvailable = false;
                                                /*ThreadPool.QueueUserWorkItem(
                                                  new WaitCallback(delegate (object state)
                                                  { CollectMenu(table, square.squareSupervisor); }), null);*/
                                                threadCMSemaphore.WaitOne();
                                                Task threadCM = new Task(() => CollectMenu(table, squareSupervisor));
                                                getOutOfLoop = true;
                                                threadCM.Start();
                                                break;
                                            case DishState.WaitToBePlaced:
                                                table.groupClient.dishState = DishState.Waiting;
                                                Console.WriteLine("Placer les clients");
                                                squareSupervisor.isAvailable = false;
                                                /*ThreadPool.QueueUserWorkItem(
                                                  new WaitCallback(delegate (object state)
                                                  { EscortClient(table, square.squareSupervisor); }), null);    */
                                                threadECSemaphore.WaitOne();
                                                Task threadEC = new Task(() => EscortClient(table, squareSupervisor));
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
            MoveToClient(squareSupervisor);
            Task threadClient = new Task(() => MoveClient(table, squareSupervisor));
            threadClient.Start();
            MoveToTable(table, squareSupervisor);
            table.groupClient.dishState = DishState.WaitMenu;
            MoveToWelcome(table, squareSupervisor);
            squareSupervisor.isAvailable = true;
            threadECSemaphore.Release();
        }

        /// <summary>
        /// Méthode permettant de faire bouger le personnage en fonction de la classe Clock
        /// </summary>
        public void MoveToTable(Table table, SquareSupervisor squareSupervisor)
        {
            squareSupervisor.NotifyObservers(table.supervisorTravelList);
        }

        public void MoveToClient(SquareSupervisor squareSupervisor)
        {
            squareSupervisor.NotifyObservers(new List<Point> { ConstantPosition.initialClient });
        }

        public void MoveClient(Table table, SquareSupervisor squareSupervisor)
        {
            squareSupervisor.NotifyObservers(table.supervisorTravelList, table);
        }

        /// <summary>
        /// Méthode permettant de se déplacer à l'accueil
        /// </summary>
        private void MoveToWelcome(Table table, SquareSupervisor squareSupervisor)
        {
            squareSupervisor.NotifyObservers(table.returnSquareList);
        }

        /// <summary>
        /// Méthode pour aller récupérer les menus et les amener aux clients
        /// </summary>
        public void SearchMenu(Table table, SquareSupervisor squareSupervisor)
        {
            MoveToTable(table, squareSupervisor);
            groupClientController.ThreadChoseMenu(table.groupClient);
            table.menus = table.groupClient.clientNumber;
            MoveToWelcome(table, squareSupervisor);
            squareSupervisor.isAvailable = true;
            threadSMSemaphore.Release();
        }


        /// <summary>
        /// Méthode pour aller récupérer les menus des clients et prendre leur commande en même temps
        /// </summary>
        public void CollectMenu(Table table, SquareSupervisor squareSupervisor)
        {
            MoveToTable(table, squareSupervisor);
            //MessageBox.Show("WaitBreadAndWater");
            table.menus = 0;
            GetCommande(table, squareSupervisor);
            MoveToWelcome(table, squareSupervisor);
            squareSupervisor.isAvailable = true;
            threadCMSemaphore.Release();
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
            model.counter.waitingGroupCommand.Add(groupCommandTemp);
            MoveToWelcome(table, squareSupervisor);
            squareSupervisor.isAvailable = true;
        }
    }
}
