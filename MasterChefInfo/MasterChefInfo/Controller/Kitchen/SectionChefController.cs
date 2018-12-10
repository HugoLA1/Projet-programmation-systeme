using System;
using System.Windows.Forms;

namespace MasterChefInfo
{
    class SectionChefController
    {
        private Model model;

        public SectionChefController(Model model)
        {
            this.model = model;
        }

        public Command MakePartOfCommand(SectionChef sectionChef, Command command)
        {
            string partOfCommand = command.recipe[0];

           /* Console.WriteLine(command.name);
            Console.WriteLine(partOfCommand);*/


            switch (partOfCommand)
            {
                case "Ajouter":
                    MoveToStorageRoom(sectionChef);
                    command.recipe.Remove(partOfCommand);
                    ReturnSR(sectionChef);
                    break;
                case "Four":
                    MoveToBakery(sectionChef);
                    command.recipe.Remove(partOfCommand);
                    ReturnClassic(sectionChef);
                    break;
                case "Mélanger":
                    MoveToWorkSurface(sectionChef);
                    command.recipe.Remove(partOfCommand);
                    ReturnClassic(sectionChef);
                    break;
                case "Servir":
                    MoveToWorkSurface(sectionChef);
                    command.recipe.Remove(partOfCommand);
                    ReturnClassic(sectionChef);
                    break;
                default:
                    MoveToWorkSurface(sectionChef);
                    command.recipe.Remove(partOfCommand);
                    ReturnClassic(sectionChef);
                    break;
            }
            return command;
                
        }

        public void MoveToBakery(SectionChef sectionChef)
        {
            sectionChef.NotifyObservers(model.kitchen.travelToBakery);
        }

        public void MoveToStorageRoom(SectionChef sectionChef)
        {
            sectionChef.NotifyObservers(model.kitchen.travelToSR);
        }

        public void MoveToWorkSurface(SectionChef sectionChef)
        {
            sectionChef.NotifyObservers(model.kitchen.travelToWS);
        }

        public void ReturnClassic(SectionChef sectionChef)
        {
            sectionChef.NotifyObservers(model.kitchen.returnClassic);
        }

        public void ReturnSR (SectionChef sectionChef)
        {
            sectionChef.NotifyObservers(model.kitchen.returnFrmoSR);
        }

    }
}
