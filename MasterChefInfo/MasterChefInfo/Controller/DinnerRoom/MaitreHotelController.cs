using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterChefInfo
{
    class MaitreHotelController
    {
        Model model;
        Thread threadMH;

        public MaitreHotelController(Model model)
        {
            this.model = model;
            CreateThread();
        }

        public void CreateThread()
        {
            threadMH = new Thread(new ThreadStart(WatchLoop));
            threadMH.Start();
        }

        public void WatchLoop()
        {
            while (Thread.CurrentThread.IsAlive)
            {
                if(model.dinnerRoom.waitingGroupClients.Count > 0)
                {
                    GroupClient groupClient = model.dinnerRoom.waitingGroupClients[0];
                    model.dinnerRoom.waitingGroupClients.Remove(groupClient);
                    AssignToTable(groupClient);

                }
                Thread.Sleep(100);
            }
        }

        public void AssignToTable(GroupClient groupClient)
        {
            foreach(Table table in )
        }
    }
}
