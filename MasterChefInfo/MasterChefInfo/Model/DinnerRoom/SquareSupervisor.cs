using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterChefInfo
{
    /// <summary>
    /// La classe des SuperVisor (Positions et disponibiblité)
    /// </summary>
    class SquareSupervisor
    {
        public bool isAvailable { get; set; }

        public int posX { get; set; }
        public int posY { get; set; }

        public SquareSupervisor()
        {
            isAvailable = true;
        }
    }
}
