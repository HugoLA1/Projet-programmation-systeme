using SpriteLibrary;
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

        public List<Sprite> itemsSprite;
        public List<Sprite> clientsSprite;

        public List<Point> travelList;
        public List<Point> supervisorTravelList;
        public List<Point> returnCounterList;
        public List<Point> returnSquareList;

        public Table(int posX, int posY, int places)
        {
            this.places = places;
            this.posX = posX;
            this.posY = posY;

            bread = 0;
            water = 0;

            groupClient = null;
             
            clientsSprite = new List<Sprite>();
            itemsSprite = new List<Sprite>();

            travelList = new List<Point> { new Point(ConstantPosition.pixelSizeOfBlock * 12, posY), new Point(posX, posY) };
            supervisorTravelList = new List<Point> { new Point(ConstantPosition.initialSquareSupervisor1PosX, posY), new Point(posX, posY) };

            returnCounterList = new List<Point> { new Point(ConstantPosition.pixelSizeOfBlock * 12, posY), ConstantPosition.accessibleCounterDinnerRoom };
            returnSquareList = new List<Point> { new Point(ConstantPosition.initialSquareSupervisor1PosX, posY), ConstantPosition.initialSquare1Supervisor };
            
        }
    }
}