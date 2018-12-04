using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterChefInfo
{
    class Client
    {

        public Command appetizer { get; set; }
        public Command dish { get; set; }
        public Command dessert { get; set; }

        public Command CurrentCommand { get; set; }

    }
}
