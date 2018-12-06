using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterChefInfo
{
    /// <summary>
    /// Classe du client du restaurant
    /// </summary>
    class Client
    {

        public Command appetizer { get; set; }
        public Command dish { get; set; }
        public Command desert { get; set; }

        public Command CurrentCommand { get; set; }

    }
}
