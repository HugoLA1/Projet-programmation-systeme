using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterChefInfo
{
    /// <summary>
    /// Classe des tables avec leurs positions
    /// </summary>
    class Table
    {
        public int places { get; set; }
        public int posX { get; set; }
        public int posY { get; set; }

        public int menus { get; set; }
        public int bread { get; set; }
        public int water { get; set; }

        public GroupClient groupClient { get; set; }

        public List<Point> travelList;

        public Table(int posX, int posY, int places)
        {
            this.places = places;
            this.posX = posX;
            this.posY = posY;

            bread = 0;
            water = 0;

            groupClient = null;

            travelList.Add(new Point(ConstantPosition.pixelSizeOfBlock * 12,posY));
            travelList.Add(new Point(posX, posY));
        }
    }
}