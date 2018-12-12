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
    /// La classe permettant de controler les serveurs
    /// </summary>
    class WaiterController
    {
        Model model;
        Thread threadW;
        GroupClientController groupClientController;

        public WaiterController(Model model, GroupClientController groupClientController)
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
            threadW = new Thread(() => WatchLoop());
            threadW.Start();
        }

        /// <summary>
        /// Surveille les variations des états et lance la méthode adapté en fonction (Ici : Apporter Pain/eau, Débarasser quand un plat est fini, Lancer le prochain plat)
        /// </summary>
        public void WatchLoop()
        {
            while (Thread.CurrentThread.IsAlive)
            {
                bool getOutOfLoop = false;
                foreach (Waiter waiter in model.dinnerRoom.waiters)
                {
                    if (waiter.isAvailable)
                    {
                        foreach (Square square in model.dinnerRoom.squares)
                        {
                            foreach (Line line in square.lines)
                            {
                                foreach (Table table in line.tables)
                                {
                                    if (table.groupClient != null)
                                    {
                                        switch (table.groupClient.dishState)
                                        {
                                            case DishState.WaitBreadAndWater:
                                                waiter.isAvailable = false;
                                                Console.WriteLine("Apporter le pain");
                                                table.groupClient.dishState = DishState.WaitGetApetizer;
                                                Task threadBAWa = new Task(() => PutBreadAndWater(table, waiter));
                                                getOutOfLoop = true;
                                                threadBAWa.Start();
                                                break;

                                            case DishState.FinishedApetizer:
                                                waiter.isAvailable = false;
                                                Console.WriteLine("débarasser entrée");
                                                table.groupClient.dishState = DishState.WaitGetDish;
                                                Task threadFA = new Task(() => CleanTable(table, waiter));
                                                getOutOfLoop = true;
                                                threadFA.Start();
                                                break;

                                            case DishState.FinishedDish:
                                                waiter.isAvailable = false;
                                                Console.WriteLine("débarasser plat");
                                                table.groupClient.dishState = DishState.WaitGetDesert;
                                                Task threadFDi = new Task(() => CleanTable(table, waiter));
                                                getOutOfLoop = true;
                                                threadFDi.Start();
                                                break;

                                            case DishState.FinishedDesert:
                                                waiter.isAvailable = false;
                                                Console.WriteLine("débarasser dessert");
                                                table.groupClient.dishState = DishState.WaitNote;
                                                Task threadFDe = new Task(() => CleanTable(table, waiter));
                                                getOutOfLoop = true;
                                                threadFDe.Start();
                                                break;

                                            case DishState.WaitGetApetizer:
                                                lock (model.counter.waitingGroupCommand)
                                                {
                                                    foreach (GroupCommand groupCommand in model.counter.waitingGroupCommand)
                                                    {
                                                        if ((groupCommand.table == table) && (groupCommand.nbCommand == groupCommand.commands.Count))
                                                        {
                                                            waiter.isAvailable = false;
                                                            Console.WriteLine("Apporter entrée");
                                                            table.groupClient.dishState = DishState.EatingApetizer;
                                                            Task threadSA = new Task(() => ServeApetizer(table, waiter, groupCommand));
                                                            getOutOfLoop = true;
                                                            threadSA.Start();
                                                        }
                                                    }
                                                }

                                                break;

                                            case DishState.WaitGetDish:
                                                lock (model.counter.waitingGroupCommand)
                                                {
                                                    foreach (GroupCommand groupCommand in model.counter.waitingGroupCommand)
                                                    {
                                                        if ((groupCommand.table == table) && (groupCommand.nbCommand == groupCommand.commands.Count))
                                                        {
                                                            waiter.isAvailable = false;
                                                            Console.WriteLine("Apporter plat");
                                                            table.groupClient.dishState = DishState.EatingDish;
                                                            Task threadSDi = new Task(() => ServeDish(table, waiter, groupCommand));
                                                            getOutOfLoop = true;
                                                            threadSDi.Start();
                                                        }
                                                    }
                                                }

                                                break;

                                            case DishState.WaitGetDesert:
                                                lock (model.counter.waitingGroupCommand)
                                                {
                                                    foreach (GroupCommand groupCommand in model.counter.waitingGroupCommand)
                                                    {
                                                        if ((groupCommand.table == table) && (groupCommand.nbCommand == groupCommand.commands.Count))
                                                        {
                                                            waiter.isAvailable = false;
                                                            Console.WriteLine("Apporter dessert");
                                                            table.groupClient.dishState = DishState.EatingDesert;
                                                            Task threadSDe = new Task(() => ServeDesert(table, waiter, groupCommand));
                                                            getOutOfLoop = true;
                                                            threadSDe.Start();
                                                        }
                                                    }
                                                }

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
                    if (getOutOfLoop) break;
                }
                Thread.Sleep(100);
            }
        }

        /// <summary>
        /// Méthode permettant de servir les desserts
        /// </summary>
        private void ServeDesert(Table table, Waiter waiter, GroupCommand groupCommand)
        {
            model.counter.waitingGroupCommand.Remove(groupCommand);
            MoveToTable(table, waiter);
            assignItemToTable(waiter, table, "glace");
            groupClientController.ThreadEatDesert(table.groupClient);

            foreach (Command command in groupCommand.commands)
            {
                table.groupClient.commands.Add(command);
            }
            MoveToCounter(table, waiter);
            waiter.isAvailable = true;
        }

        /// <summary>
        /// Méthode permettant de servir les plats
        /// </summary>
        public void ServeDish(Table table, Waiter waiter, GroupCommand groupCommand)
        {
            model.counter.waitingGroupCommand.Remove(groupCommand);
            MoveToTable(table, waiter);
            assignItemToTable(waiter, table, "pizza");
            groupClientController.ThreadEatDish(table.groupClient);
            foreach (Command command in groupCommand.commands)
            {

                table.groupClient.commands.Add(command);
            }
            MoveToCounter(table, waiter);
            waiter.isAvailable = true;
        }

        /// <summary>
        /// Méthode permettant de servir les entrées
        /// </summary>
        private void ServeApetizer(Table table, Waiter waiter, GroupCommand groupCommand)
        {

            model.counter.waitingGroupCommand.Remove(groupCommand);
            MoveToTable(table, waiter);
            assignItemToTable(waiter, table, "salade");
            groupClientController.ThreadEatApetizer(table.groupClient);
            foreach (Command command in groupCommand.commands)
            {
                table.groupClient.commands.Add(command);
            }

            MoveToCounter(table, waiter);
            waiter.isAvailable = true;
        }

        /// <summary>
        /// Méthode permettant de se déplacer à une table
        /// </summary>
        public void MoveToTable(Table table, Waiter waiter)
        {
            waiter.NotifyObservers(table.travelList);
        }

        /// <summary>
        /// Méthode permettant de se déplacer au contoir
        /// </summary>
        public void MoveToCounter(Table table, Waiter waiter)
        {
            waiter.NotifyObservers(table.returnCounterList);
        }

        /// <summary>
        /// Méthode permettant de servir le pain et l'eau
        /// </summary>
        public void PutBreadAndWater(Table table, Waiter waiter)
        {
            MoveToTable(table, waiter);
            if (table.groupClient.clientNumber > 5)
            {
                table.bread = 2;
                table.water = 2;
            }
            else
            {
                table.bread = 1;
                table.water = 1;
            }
            MoveToCounter(table, waiter);
            waiter.isAvailable = true;
        }

        public void assignItemToTable(Waiter waiter, Table table, string type)
        {
            waiter.NotifyObservers(table, type);
        }

        /// <summary>
        /// Méthode permettant de débarasser la table
        /// </summary>
        public void CleanTable(Table table, Waiter waiter)
        {
            MoveToTable(table, waiter);
            assignItemToTable(waiter, table, "noitem");
            if(table.groupClient != null)
            {
                switch (table.groupClient.dishState)
                {
                    case DishState.WaitGetDish:
                        model.counter.waitingGroupCommand.Add(new GroupCommand(table));
                        foreach (Client client in table.groupClient.clients)
                        {
                            client.dish.table = table;
                            model.kitchen.cookingRoom.masterChef.commandsToDo.Add(client.dish);
                        }

                        break;
                    case DishState.WaitGetDesert:
                        model.counter.waitingGroupCommand.Add(new GroupCommand(table));
                        foreach (Client client in table.groupClient.clients)
                        {
                            client.desert.table = table;
                            model.kitchen.cookingRoom.masterChef.commandsToDo.Add(client.desert);
                        }
                        break;
                }
            }
            MoveToCounter(table, waiter);
            waiter.isAvailable = true;
        }
    }
}
