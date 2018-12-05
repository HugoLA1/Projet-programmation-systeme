using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterChefInfo
{
    /// <summary>
    /// Classe des serveurs
    /// </summary>
    class Waiter
    {
        public int posX { get; set; }
        public int posY { get; set; }

        public bool isAvailable;

        /// <summary>
        /// Contient la disponibilité des serveurs
        /// </summary>
        public Waiter()
        {
            isAvailable = true;
        }
    }
}
