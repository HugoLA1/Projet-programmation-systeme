using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterChefInfo
{
    class SectionChefController
    {
        private Model model;

        public SectionChefController(Model model)
        {
            this.model = model;
        }

        public SectionChef GetSectionChefAvailable()
        {
            return new SectionChef();
        }

        public Command MakePartOfCommand(SectionChef sectionChef, Command command)
        {
            
        }

        public void MoveToBakery()
        {

        }

        public void MoveToStorageRoom()
        {

        }

        public void MoveToWorkSurface()
        {

        }

        public void MoveToCounter()
        {

        }

        public void GetIngredient(String name)
        {

        }

        public void WaitOperation(int second)
        {

        }
    }
}
