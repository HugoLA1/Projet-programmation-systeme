using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterChefInfo
{
    class Counter
    {

        public int posX { get; set; }
        public int posY { get; set; }

        public List<Command> waitingCommand { get; set; }

        public Counter()
        {

        }
    }
}
