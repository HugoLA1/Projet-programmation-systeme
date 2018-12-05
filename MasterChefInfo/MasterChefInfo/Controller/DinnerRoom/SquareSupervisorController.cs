using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MasterChefInfo
{
    class SquareSupervisorController
    {
        public SquareSupervisor GetSquareSupervisor(Square square)
        {
            return new SquareSupervisor();
        }

        Model model;
        Thread threadS;

        public void CreateThread()
        {
            threadS = new Thread(new ThreadStart(WatchLoop));
            threadS.Start();
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
                                        case DishState.WaitMenu:
                                            SearchMenu(model.dinnerRoom.squares[s].lines[l].tables[t], model.dinnerRoom.squares[s].waiters[w]);
                                            break;
                                        case DishState.Choosed:
                                            CollectMenu(model.dinnerRoom.squares[s].lines[l].tables[t], model.dinnerRoom.squares[s].waiters[w]);
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

        public void EscortClient(GroupClient groupClient)
        {

        }

        public void MoveToTable(Table table)
        {

        }

        public void SearchMenu (Table table, Waiter waiter)
        {

        }

        public void CollectMenu(Table table, Waiter waiter)
        {

        }

        public void GetCommande(Table table, Waiter waiter)
        {

        }
    }
}
