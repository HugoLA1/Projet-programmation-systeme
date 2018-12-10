using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterChefInfo
{
    /// <summary>
    /// Classe du lave vaiselle
    /// </summary>
    class DishWasher
    {
        public int posX { get; set; }
        public int posY { get; set; }

        public DishWasher()
        {

        }

        internal void NotifyObservers(DishWasher dishWasher)
        {
            throw new NotImplementedException();
        }
    }
}
