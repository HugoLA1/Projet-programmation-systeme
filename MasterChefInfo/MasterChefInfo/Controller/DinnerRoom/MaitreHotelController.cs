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
                if(model.dinnerRoom.waitingGroupClients != null)
                {
                    MessageBox.Show("Un group a été crée");
                }
                Thread.Sleep(100);
            }
        }

        public void AssignToTable()
        {

        }
    }
}
