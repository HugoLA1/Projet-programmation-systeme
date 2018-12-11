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
        public List<GroupClient> waitingGroupClients { get; set; }
        public List<Square> squares { get; set; }
        public MaitreHotel maitreHotel { get; set; }
        public List<Waiter> waiters { get; set; }

        public int menu { get; set; }

        public DinnerRoom()
        {
            waitingGroupClients = new List<GroupClient> { };

            squares = new List<Square> { };

            squares.Add(new Square(15));
            squares.Add(new Square(38));
            maitreHotel = new MaitreHotel();
            waiters = new List<Waiter>();
            menu = 40;

            for (int i = 0; i < ConstantGeneral.numberOfWaiter; i++)
            {
                waiters.Insert(i, new Waiter(i));
            }
        }

        public void AddGroupClient(GroupClient groupClient)
        {

        }
    }
}
