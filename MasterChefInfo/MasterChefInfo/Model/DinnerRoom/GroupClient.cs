using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterChefInfo
{
    class GroupClient
    {
        public List<Client> clients { get; set; }
        public int clientNumber { get; set; }
        public DishState dishState { get; set; }
    }
}
