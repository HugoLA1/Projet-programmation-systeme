using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterChefInfo
{
    class GroupClient
    {
        public Client[] clients { get; set; }
        public int clientNumber { get; set; }
        public DishState dishState { get; set; }
        public int finalPrice { get; set; }

        public GroupClient(int clientNumber)
        {
            clients = new Client[clientNumber];
            this.clientNumber = clientNumber;

        }
    }
}
