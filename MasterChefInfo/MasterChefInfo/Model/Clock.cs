using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace MasterChefInfo
{
    /// <summary>
    /// Classe de l'horloge permettant d'obtenir l'heure et la date
    /// </summary>
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
