using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterChefInfo
{
    class CleanningRoom
    {
        List<Ustensil> dirtyUstensil;
        WashingMachine washingMachine;
        DishWasher dishWasher;

        public CleanningRoom()
        {
            washingMachine = new WashingMachine();
            dishWasher = new DishWasher();
        }
    }
}
