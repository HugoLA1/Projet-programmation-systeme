using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterChefInfo
{
    class Square
    {
        List<Line> lines;
        List<Waiter> waiters;
        SquareSupervisor squareSupervisor;
        

        public Square()
        {
            lines.Add(new Line());
            lines.Add(new Line());

            waiters.Add(new Waiter());
            waiters.Add(new Waiter());

            squareSupervisor = new SquareSupervisor();
        }
    }
}
