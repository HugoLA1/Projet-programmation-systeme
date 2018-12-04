using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterChefInfo
{
    class Model
    {

        DataBaseExchanger BDD;
        RequestMapper requestMapper;
        DinnerRoom dinnerRoom;
        Kitchen kitchen;
        Counter counter;
                
        public Model()
        {
            BDD = new DataBaseExchanger();
            requestMapper = new RequestMapper();
            dinnerRoom = new DinnerRoom();
            kitchen = new Kitchen();
            counter = new Counter();
        }

    }
}
