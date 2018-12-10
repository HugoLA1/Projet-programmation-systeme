using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterChefInfo
{
    /// <summary>
    /// Classe de la cuisine
    /// </summary>
    class Kitchen
    {
        public CleanningRoom cleanningRoom { get; set; }
        public CookingRoom cookingRoom { get; set; }
        public StorageRoom storageRoom { get; set; }

        public List<Point> travelToBakery { get; set; }

        public List<Point> travelToWS { get; set; }

        public List<Point> travelToSR { get; set; }

        public List<Point> returnClassic { get; set; }
        public List<Point> returnFrmoSR { get; set; }




        public Kitchen()
        {
            cleanningRoom = new CleanningRoom();
            cookingRoom = new CookingRoom();
            storageRoom = new StorageRoom();

            travelToBakery = new List<Point> {new Point(ConstantPosition.pixelSizeOfBlock * 2, ConstantPosition.pixelSizeOfBlock * 15)};
            travelToWS = new List<Point> {new Point(ConstantPosition.pixelSizeOfBlock * 3, ConstantPosition.pixelSizeOfBlock * 15)};
            travelToSR = new List<Point> {new Point(ConstantPosition.pixelSizeOfBlock * 6, ConstantPosition.pixelSizeOfBlock * 18), new Point(ConstantPosition.pixelSizeOfBlock * 9, ConstantPosition.pixelSizeOfBlock * 18) , new Point(ConstantPosition.pixelSizeOfBlock * 9, ConstantPosition.pixelSizeOfBlock * 9) };

            returnClassic = new List<Point> { ConstantPosition.sectionChef };
            returnFrmoSR = new List<Point> { new Point(ConstantPosition.pixelSizeOfBlock * 9, ConstantPosition.pixelSizeOfBlock * 18), new Point(ConstantPosition.pixelSizeOfBlock * 6, ConstantPosition.pixelSizeOfBlock * 18), ConstantPosition.sectionChef };
            }
    }
}
