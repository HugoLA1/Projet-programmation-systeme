using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterChefInfo
{
    class WaiterController
    {
        Model model;
        Thread threadW;

        public void CreateThread()
        {
            threadW = new Thread(new ThreadStart(WatchLoop));
            threadW.Start();
        }

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
                                    switch (model.dinnerRoom.squares[s].lines[l].tables[t].groupClient.dishState)
                                    {
                                        case DishState.WaitBreadAndWater:
                                            PutBreadAndWater(model.dinnerRoom.squares[s].lines[l].tables[t], model.dinnerRoom.squares[s].waiters[w]);
                                            break;
                                        case DishState.FinishedApetizer:
                                            CleanTable(model.dinnerRoom.squares[s].lines[l].tables[t], model.dinnerRoom.squares[s].waiters[w]);
                                            break;
                                        case DishState.FinishedDish:
                                            CleanTable(model.dinnerRoom.squares[s].lines[l].tables[t], model.dinnerRoom.squares[s].waiters[w]);
                                            break;
                                        case DishState.FinishedDesert:
                                            CleanTable(model.dinnerRoom.squares[s].lines[l].tables[t], model.dinnerRoom.squares[s].waiters[w]);
                                            break;
                                        case DishState.WaitGetApetizer:
                                            foreach (GroupCommand groupCommand in model.counter.waitingGroupCommand)
                                            {
                                                if (groupCommand.table == model.dinnerRoom.squares[s].lines[l].tables[t])
                                                {
                                                    ServeApetizer(model.dinnerRoom.squares[s].lines[l].tables[t], model.dinnerRoom.squares[s].waiters[w], groupCommand);
                                                }
                                            }
                                            break;

                                        case DishState.WaitGetDish:
                                            foreach (GroupCommand groupCommand in model.counter.waitingGroupCommand)
                                            {
                                                if (groupCommand.table == model.dinnerRoom.squares[s].lines[l].tables[t])
                                                {
                                                    ServeDish(model.dinnerRoom.squares[s].lines[l].tables[t], model.dinnerRoom.squares[s].waiters[w], groupCommand);
                                                }
                                            }
                                            break;

                                        case DishState.WaitGetDesert:
                                            foreach (GroupCommand groupCommand in model.counter.waitingGroupCommand)
                                            {
                                                if (groupCommand.table == model.dinnerRoom.squares[s].lines[l].tables[t])
                                                {
                                                    ServeDesert(model.dinnerRoom.squares[s].lines[l].tables[t], model.dinnerRoom.squares[s].waiters[w], groupCommand);
                                                }
                                            }
                                            break;
                                    }
                                }
                            }
                        }
                    }
                }   
                Thread.Sleep(100);
            }
        }

        private void ServeDesert(Table table, Waiter waiter, GroupCommand groupCommand)
        {
            throw new NotImplementedException();
        }

        private void ServeApetizer(Table table, Waiter waiter, GroupCommand groupCommand)
        {
            throw new NotImplementedException();
        }

        public void MoveToTable(Table table, Waiter waiter)
        {

        }

        public void PutBreadAndWater(Table table, Waiter waiter)
        {

        }

        public void ServeDish(Table table, Waiter waiter, GroupCommand groupCommand)
        {

        }

        public void CleanTable(Table table, Waiter waiter)
        {

        }
    }
}
