using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterChefInfo
{    
    /// <summary>
     /// Classe de l'espace de nétoyage (plonge)
     /// </summary>
    class CleanningRoom
    {
        public List<Ustensil> dirtyUstensil { get; set; }
        public WashingMachine washingMachine { get; set; }
        public DishWasher dishWasher { get; set; }

        public List<Point> travelToCounter { get; set; }
        public List<Point> travelToDW { get; set; }


        public CleanningRoom()
        {
            washingMachine = new WashingMachine();
            dishWasher = new DishWasher();
            travelToCounter = new List<Point> { new Point(ConstantPosition.pixelSizeOfBlock * 3, ConstantPosition.pixelSizeOfBlock * 8), new Point(ConstantPosition.pixelSizeOfBlock * 10, ConstantPosition.pixelSizeOfBlock * 14) };
            travelToDW = new List<Point> { new Point(ConstantPosition.pixelSizeOfBlock * 10, ConstantPosition.pixelSizeOfBlock * 14), new Point(ConstantPosition.pixelSizeOfBlock * 3, ConstantPosition.pixelSizeOfBlock * 8) };

        }
    }
}
