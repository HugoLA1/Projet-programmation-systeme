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
            threadW = new Thread(new ThreadStart(WatchLoop));
            threadW.Start();
        }

        /// <summary>
        /// Surveille les variations des états et lance la méthode adapté en fonction (Ici : Apporter Pain/eau, Débarasser quand un plat est fini, Lancer le prochain plat)
        /// </summary>
        public void WatchLoop()
        {
            while (Thread.CurrentThread.IsAlive)
            {
                for (int s = 0; s < model.dinnerRoom.squares.Count; s++)
                {
                    for (int w = 0; w < model.dinnerRoom.squares[s].waiters.Count; w++)
                    {
                        if (model.dinnerRoom.squares[s].waiters[w].isAvailable)
                        {
                            for (int l = 0; l < model.dinnerRoom.squares[s].lines.Count; l++)
                            {
                                for (int t = 0; t < model.dinnerRoom.squares[s].lines[l].tables.Count; t++)
                                {
                                    if(model.dinnerRoom.squares[s].lines[l].tables[t].groupClient != null)
                                    {
                                    switch (model.dinnerRoom.squares[s].lines[l].tables[t].groupClient.dishState)
                                    {
                                        case DishState.WaitBreadAndWater:
                                            model.dinnerRoom.squares[s].waiters[w].isAvailable = false;
                                            Thread threadBAW = new Thread(() => CleanTable(model.dinnerRoom.squares[s].lines[l].tables[t], model.dinnerRoom.squares[s].waiters[w]));
                                            threadBAW.Start();
                                            break;

                                        case DishState.FinishedApetizer:
                                            model.dinnerRoom.squares[s].waiters[w].isAvailable = false;
                                            Thread threadFA = new Thread(() => CleanTable(model.dinnerRoom.squares[s].lines[l].tables[t], model.dinnerRoom.squares[s].waiters[w]));
                                            threadFA.Start();
                                            break;

                                        case DishState.FinishedDish:
                                            model.dinnerRoom.squares[s].waiters[w].isAvailable = false;
                                            Thread threadFDi = new Thread(() => CleanTable(model.dinnerRoom.squares[s].lines[l].tables[t], model.dinnerRoom.squares[s].waiters[w]));
                                            threadFDi.Start();
                                            break;

                                        case DishState.FinishedDesert:
                                            model.dinnerRoom.squares[s].waiters[w].isAvailable = false;
                                            Thread threadFDe = new Thread(() => CleanTable(model.dinnerRoom.squares[s].lines[l].tables[t], model.dinnerRoom.squares[s].waiters[w]));
                                            threadFDe.Start();
                                            break;

                                        case DishState.WaitGetApetizer:
                                            foreach (GroupCommand groupCommand in model.counter.waitingGroupCommand)
                                            {
                                                if (groupCommand.table == model.dinnerRoom.squares[s].lines[l].tables[t])
                                                {
                                                    model.dinnerRoom.squares[s].waiters[w].isAvailable = false;
                                                    Thread threadSA = new Thread(() => ServeApetizer(model.dinnerRoom.squares[s].lines[l].tables[t], model.dinnerRoom.squares[s].waiters[w], groupCommand));
                                                    threadSA.Start();
                                                }
                                            }
                                            break;

                                        case DishState.WaitGetDish:
                                            foreach (GroupCommand groupCommand in model.counter.waitingGroupCommand)
                                            {
                                                if (groupCommand.table == model.dinnerRoom.squares[s].lines[l].tables[t])
                                                {
                                                    model.dinnerRoom.squares[s].waiters[w].isAvailable = false;
                                                    Thread threadSDi = new Thread(() => ServeDish(model.dinnerRoom.squares[s].lines[l].tables[t], model.dinnerRoom.squares[s].waiters[w], groupCommand));
                                                    threadSDi.Start();
                                                }
                                            }
                                            break;

                                        case DishState.WaitGetDesert:
                                            foreach (GroupCommand groupCommand in model.counter.waitingGroupCommand)
                                            {
                                                if (groupCommand.table == model.dinnerRoom.squares[s].lines[l].tables[t])
                                                {
                                                    model.dinnerRoom.squares[s].waiters[w].isAvailable = false;
                                                    Thread threadSDe = new Thread(() => ServeDesert(model.dinnerRoom.squares[s].lines[l].tables[t], model.dinnerRoom.squares[s].waiters[w], groupCommand));
                                                    threadSDe.Start();
                                                }
                                            }
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
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
            table.groupClient.dishState = DishState.EatingDesert;
            groupClientController.ThreadEatDesert(table.groupClient);
            foreach(Command command in groupCommand.commands)
            {
                table.groupClient.commands.Add(command);
            }
            Thread.Sleep(5000);
            MoveToCounter(waiter);
            waiter.isAvailable = true;
        }

        /// <summary>
        /// Méthode permettant de servir les plats
        /// </summary>
        public void ServeDish(Table table, Waiter waiter, GroupCommand groupCommand)
        {
            model.counter.waitingGroupCommand.Remove(groupCommand);
            MoveToTable(table, waiter);
            table.groupClient.dishState = DishState.EatingDish;
            groupClientController.ThreadEatDish(table.groupClient);
            foreach (Command command in groupCommand.commands)
            {
                table.groupClient.commands.Add(command);
            }
            Thread.Sleep(5000);
            MoveToCounter(waiter);
            waiter.isAvailable = true;
        }

        /// <summary>
        /// Méthode permettant de servir les entrées
        /// </summary>
        private void ServeApetizer(Table table, Waiter waiter, GroupCommand groupCommand)
        {
            model.counter.waitingGroupCommand.Remove(groupCommand);
            MoveToTable(table, waiter);
            table.groupClient.dishState = DishState.EatingApetizer;
            groupClientController.ThreadEatApetizer(table.groupClient);
            foreach (Command command in groupCommand.commands)
            {
                table.groupClient.commands.Add(command);
            }
            Thread.Sleep(5000);
            MoveToCounter(waiter);
            waiter.isAvailable = true;
        }

        /// <summary>
        /// Méthode permettant de se déplacer à une table
        /// </summary>
        public void MoveToTable(Table table, Waiter waiter)
        {

        }

        /// <summary>
        /// Méthode permettant de se déplacer au contoir
        /// </summary>
        public void MoveToCounter(Waiter waiter)
        {

        }

        /// <summary>
        /// Méthode permettant de servir le pain et l'eau
        /// </summary>
        public void PutBreadAndWater(Table table, Waiter waiter)
        {
            MoveToTable(table, waiter);
            table.groupClient.dishState = DishState.WaitGetApetizer;
            if(table.groupClient.clientNumber > 5)
            {
                table.bread = 2;
                table.water = 2;
            }
            else
            {
                table.bread = 1;
                table.water = 1;
            }
            MoveToCounter(waiter);
            Thread.Sleep(2000);
            waiter.isAvailable = true;
        }

        /// <summary>
        /// Méthode permettant de débarasser la table
        /// </summary>
        public void CleanTable(Table table, Waiter waiter)
        {
            MoveToTable(table, waiter);
            switch (table.groupClient.dishState)
            {
                case DishState.FinishedApetizer:
                    table.groupClient.dishState = DishState.WaitGetDish;
                    break;
                case DishState.FinishedDish:
                    table.groupClient.dishState = DishState.WaitGetDesert;
                    break;
                case DishState.FinishedDesert:
                    table.groupClient.dishState = DishState.WaitNote;
                    break;
            }
            foreach (Command command in table.groupClient.commands)
            {
                table.groupClient.commands.Remove(command);
                foreach(Ustensil ustensil in command.ustensils)
                {
                    model.kitchen.cleanningRoom.dirtyUstensil.Add(ustensil);
                }
            }

            model.counter.waitingGroupCommand.Add(new GroupCommand(table.groupClient.clientNumber, table));

            foreach(Client client in table.groupClient.clients)
            {
                switch (table.groupClient.dishState)
                {
                    case DishState.WaitGetDish:
                        model.kitchen.cookingRoom.masterChef.commandsToDo.Add(client.dish);
                        break;
                    case DishState.WaitGetDesert:
                        model.kitchen.cookingRoom.masterChef.commandsToDo.Add(client.desert);
                        break;
                }
            }
            Thread.Sleep(5000);
            MoveToCounter(waiter);
            waiter.isAvailable = true;
        }
    }
}
