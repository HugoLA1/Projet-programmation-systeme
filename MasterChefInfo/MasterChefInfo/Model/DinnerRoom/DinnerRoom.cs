using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterChefInfo
{
    /// <summary>
    /// Classe des salles principales
    /// </summary>
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

            squares.Add(new Square(17));
            squares.Add(new Square(43 + 17));
            maitreHotel = new MaitreHotel();
            menu = 40;
        }

        public void AddGroupClient(GroupClient groupClient)
        {

        }
    }
}
