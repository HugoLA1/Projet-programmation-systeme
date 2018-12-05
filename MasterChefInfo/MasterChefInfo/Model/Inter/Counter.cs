using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterChefInfo
{
    /// <summary>
    /// Classe du comptoir
    /// </summary>
    class Counter
    {

        public int posX { get; set; }
        public int posY { get; set; }

        public List<GroupCommand> waitingGroupCommand { get; set; }

        public Counter()
        {

        }
    }
}
