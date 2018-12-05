using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace MasterChefInfo
{
    class Clock
    {
        private static System.Timers.Timer aTimer;

        public DateTime GetDate()
        {
            DateTime currentTime = DateTime.Now;
            return currentTime;
        }
    }
}
