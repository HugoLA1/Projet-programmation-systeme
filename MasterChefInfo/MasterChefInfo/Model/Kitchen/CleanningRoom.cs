using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterChefInfo
{
    class CleanningRoom
    {
        public List<Ustensil> dirtyUstensil { get; set; }
        public WashingMachine washingMachine { get; set; }
        public DishWasher dishWasher { get; set; }

        public CleanningRoom()
        {
            washingMachine = new WashingMachine();
            dishWasher = new DishWasher();
        }
    }
}
