using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterChefInfo
{
    class DinnerRoom
    {
        public List<GroupClient> waitingGroupClients;
        public List<Square> squares { get; set; }
        public MaitreHotel maitreHotel { get; set; }
        public int menu { get; set; }

        public DinnerRoom()
        {

            waitingGroupClients = new List<GroupClient> { };

            squares = new List<Square> { };

            squares.Add(new Square());
            squares.Add(new Square());
            maitreHotel = new MaitreHotel();
            menu = 40;
        }

        public void AddGroupClient(GroupClient groupClient)
        {

        }
    }
}
