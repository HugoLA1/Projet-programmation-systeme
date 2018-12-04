using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterChefInfo
{
    class GroupClient
    {

        enum DishState { WaitMenu, Choosing, WaitDoOrderApetizer, WaitBreadAndWater, WaitCommandApetizer, EatingApetizer, FinishedApetizer, WaitDoOrderDish, EatingDish, FinishedDish, WaitDoOrderDessert, EatingDessert, FinishedDessert, WaitNote };

        List<Client> clients;
        int clientNumber;
        DishState dishState;
    }
}
