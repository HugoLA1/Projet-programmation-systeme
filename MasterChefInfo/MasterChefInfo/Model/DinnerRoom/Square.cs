using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterChefInfo
{
    class Square
    {
        public List<Line> lines { get; set; }
        public List<Waiter> waiters { get; set; }
        public SquareSupervisor squareSupervisor { get; set; }


        public Square()
        {
            lines = new List<Line> { };
            waiters = new List<Waiter> { };

            lines.Add(new Line());
            lines.Add(new Line());

            waiters.Add(new Waiter());
            waiters.Add(new Waiter());

            squareSupervisor = new SquareSupervisor();
        }
    }
}
