using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterChefInfo
{
    class Line
    {

        public List<Table> tables { get; set; }

        public int posX;
        public int posY;

        public Line(int posX, int posY)
        {
            this.posX = posX;
            this.posY = posY;

            tables = new List<Table> { };

            if((posX == 17) && (posY == 1)){
                tables.Add(new Table(posX + 2, posY + 3, 4));
                tables.Add(new Table(posX + 7, posY + 3, 8));
                tables.Add(new Table(posX + 12, posY + 3, 2));
                tables.Add(new Table(posX + 17, posY + 3, 6));
                tables.Add(new Table(posX + 22, posY + 3, 4));
                tables.Add(new Table(posX + 27, posY + 3, 2));
                tables.Add(new Table(posX + 32, posY + 3, 6));
                tables.Add(new Table(posX + 37, posY + 3, 4));
            }

            if ((posX == 17) && (posY == 17))
            {
                tables.Add(new Table(posX + 2, posY + 3, 8));
                tables.Add(new Table(posX + 7, posY + 3, 2));
                tables.Add(new Table(posX + 12, posY + 3, 10));
                tables.Add(new Table(posX + 17, posY + 3, 4));
                tables.Add(new Table(posX + 22, posY + 3, 6));
                tables.Add(new Table(posX + 27, posY + 3, 4));
                tables.Add(new Table(posX + 32, posY + 3, 2));
                tables.Add(new Table(posX + 37, posY + 3, 2));
            }

            if ((posX == 17 + 43) && (posY == 1))
            {
                tables.Add(new Table(posX + 2, posY + 3, 2));
                tables.Add(new Table(posX + 7, posY + 3, 10));
                tables.Add(new Table(posX + 12, posY + 3, 4));
                tables.Add(new Table(posX + 17, posY + 3, 2));
                tables.Add(new Table(posX + 22, posY + 3, 6));
                tables.Add(new Table(posX + 27, posY + 3, 4));
                tables.Add(new Table(posX + 32, posY + 3, 2));
                tables.Add(new Table(posX + 37, posY + 3, 8));
            }

            if ((posX == 17 + 43) && (posY == 17))
            {
                tables.Add(new Table(posX + 2, posY + 3, 8));
                tables.Add(new Table(posX + 7, posY + 3, 2));
                tables.Add(new Table(posX + 12, posY + 3, 4));
                tables.Add(new Table(posX + 17, posY + 3, 6));
                tables.Add(new Table(posX + 22, posY + 3, 2));
                tables.Add(new Table(posX + 27, posY + 3, 4));
                tables.Add(new Table(posX + 32, posY + 3, 8));
                tables.Add(new Table(posX + 37, posY + 3, 4));
            }

        }
    }
}
