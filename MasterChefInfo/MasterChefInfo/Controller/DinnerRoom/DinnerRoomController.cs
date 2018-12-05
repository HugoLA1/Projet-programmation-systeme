using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterChefInfo
{
    /// <summary>
    /// La classe permet de gérer la salle du restaurant, elle peut créer des nouveaux clients et les mettre 
    /// en attente dans la liste d'attente pour le scénario de test.
    /// </summary>
    class DinnerRoomController
    {
        public MaitreHotelController maitreHotelController;
        public SquareSupervisorController squareSupervisorController;
        public TableController tableController;
        public WaiterController waiterController;
        public KitchenController kitchenController;
        public Model model;

        public DinnerRoomController(Model model)
        {
            maitreHotelController = new MaitreHotelController(model);
            this.model = model;
        }

        public void NewGroupClient()
        {
            ClientGeneratorController clientGeneratorController = new ClientGeneratorController(model);
            model.dinnerRoom.waitingGroupClients.Add(clientGeneratorController.CreateNewGroupClient());
        }
    }

}
