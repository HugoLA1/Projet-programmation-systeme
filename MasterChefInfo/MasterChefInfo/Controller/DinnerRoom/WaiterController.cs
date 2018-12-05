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
                    for (int l = 0; l < model.dinnerRoom.squares[s].lines.Count; l++)
                    {
                        for (int t = 0; t < model.dinnerRoom.squares[s].lines[l].tables.Count; t++)
                        {
                            if (model.dinnerRoom.squares[s].lines[l].tables[t].groupClient.dishState == DishState.WaitBreadAndWater)
                            {

                                PutBreadAndWater(model.dinnerRoom.squares[s].lines[l].tables[t]);
                            }
                        }
                    }
                }
                Thread.Sleep(100);
            }
        }

        public void MoveToTable(Table table)
        {

        }

        public void PutBreadAndWater(Table table)
        {

        }

        public void ServeDish(Table table)
        {

        }
    }
}
