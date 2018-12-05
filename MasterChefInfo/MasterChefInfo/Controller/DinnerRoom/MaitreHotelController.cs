using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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
                //if(model.dinnerRoom.)
                Thread.Sleep(100);
            }
        }

        public void AssignToTable()
        {

        }
    }
}
