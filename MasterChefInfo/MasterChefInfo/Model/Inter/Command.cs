using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterChefInfo
{
    class Command
    {
        public int posX { get; set; }
        public int posY { get; set; }

        public List<string> recipe { get; set; }
        public List<Ustensil> ustensils { get; set; }

        public string name { get; set; }
    }
}
