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

        public MasterChefController masterChefController;
        public SectionChefController sectionChefController;
        public CleanningRoomController cleanningRoomController;

        public KitchenController(Model model)
        {
            this.model = model;
            sectionChefController = new SectionChefController(model);
            masterChefController = new MasterChefController(model, sectionChefController);
            
        }
    }
}
