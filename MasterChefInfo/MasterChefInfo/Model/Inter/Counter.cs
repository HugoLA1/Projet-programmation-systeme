using System;
using System.Collections.Generic;
using System.Drawing;
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

        public Point counterPoint { get; set; }
        public List<GroupCommand> waitingGroupCommand { get; set; }

        public Counter()
        {
            counterPoint = new Point();
            waitingGroupCommand = new List<GroupCommand> { };
        }
    }
}
