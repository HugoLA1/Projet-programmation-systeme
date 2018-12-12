using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterChefInfo
{
    /// <summary>
    /// Les étapes (états) entre l'arrivée du client et son départ
    /// </summary>
    public enum DishState {Waiting, WaitToBePlaced, WaitMenu, Choosing, Choosed, WaitBreadAndWater, WaitGetApetizer, EatingApetizer, FinishedApetizer, WaitGetDish, EatingDish, FinishedDish, WaitGetDesert, EatingDesert, FinishedDesert, WaitNote };
    /// <summary>
    /// La liste des ustensibles disponible
    /// </summary>
    public enum UstensilType { assiete, couteau, fourchette, cuillere, casserolle };
}