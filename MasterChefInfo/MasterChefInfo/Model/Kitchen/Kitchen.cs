using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterChefInfo
{
    class Kitchen
    {
        public CleanningRoom cleanningRoom { get; set; }
        public CookingRoom cookingRoom { get; set; }
        public StorageRoom storageRoom { get; set; }

        public Kitchen()
        {
            cleanningRoom = new CleanningRoom();
            cookingRoom = new CookingRoom();
            storageRoom = new StorageRoom();

        }
    }
}
