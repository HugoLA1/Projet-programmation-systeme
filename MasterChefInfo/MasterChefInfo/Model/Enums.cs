using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterChefInfo
{
    public enum DishState { WaitMenu, Choosing, Choosed, WaitDoOrderApetizer, WaitBreadAndWater, WaitCommandApetizer, EatingApetizer, FinishedApetizer, WaitDoOrderDish, EatingDish, FinishedDish, WaitDoOrderDessert, EatingDessert, FinishedDessert, WaitNote };
    public enum UstensilType { assiete, couteau, fourchette, cuillere, casserolle };
}
