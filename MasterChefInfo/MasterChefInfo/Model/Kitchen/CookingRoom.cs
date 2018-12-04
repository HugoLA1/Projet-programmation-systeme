using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterChefInfo
{
    class CookingRoom
    {
        MasterChef masterChef;
        List<Ustensil> usedUstensil;

        public CookingRoom()
        {
            masterChef = new MasterChef();
        }
    }
}
