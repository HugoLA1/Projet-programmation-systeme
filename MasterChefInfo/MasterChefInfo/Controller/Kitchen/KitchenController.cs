using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterChefInfo
{
    class KitchenController
    {
        public Model model;

        public MasterChefController masterChefController { get; set; }
        public SectionChefController sectionChefController { get; set; }
        public CleanningRoomController cleanningRoomController { get; set; }

        public KitchenController(Model model)
        {
            this.model = model;
            sectionChefController = new SectionChefController(model);
            masterChefController = new MasterChefController(model, sectionChefController);
            cleanningRoomController = new CleanningRoomController();
        }
    }
}
