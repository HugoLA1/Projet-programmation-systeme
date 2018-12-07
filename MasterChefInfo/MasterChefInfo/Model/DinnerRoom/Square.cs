using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterChefInfo
{
    /// <summary>
    /// Classe des carrés 
    /// </summary>
    class Square
    {
        public List<Line> lines { get; set; }
        public List<Waiter> waiters { get; set; }
        public SquareSupervisor squareSupervisor { get; set; }

        public int posX;

        public Square(int posX)
        {
            this.posX = posX;
            lines = new List<Line> { };
            waiters = new List<Waiter> { };

            lines.Add(new Line(posX, 1));
            lines.Add(new Line(posX, 17));

            waiters.Add(new Waiter());
            waiters.Add(new Waiter());

            squareSupervisor = new SquareSupervisor();
        }
    }
}
