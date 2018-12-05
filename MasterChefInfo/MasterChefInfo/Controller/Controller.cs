using MasterChefInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MasterChefInfo
{

    class Controller
    {
        public Model model;
        public DinnerRoomController dinnerRoomController;
        public ClientGeneratorController clientGeneratorController;

        public Controller()
        {
            model = new Model();
            clientGeneratorController = new ClientGeneratorController(model);
            clientGeneratorController.CreateNewGroupClient();

        }
    }

}
