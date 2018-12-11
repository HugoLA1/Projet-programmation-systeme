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
            if(command.recipe[0] != null)
            {
                string partOfCommand = command.recipe[0];
                switch (partOfCommand)
                {
                    case "Ajouter":
                        MoveToStorageRoom(sectionChef);
                        command.recipe.Remove(partOfCommand);
                        ReturnSR(sectionChef);
                        break;
                    case " Four":
                        MoveToBakery(sectionChef);
                        command.recipe.Remove(partOfCommand);
                        ReturnClassic(sectionChef);
                        break;
                    case " Mélanger":
                        MoveToWorkSurface(sectionChef);
                        command.recipe.Remove(partOfCommand);
                        ReturnClassic(sectionChef);
                        break;
                    case " Servir":
                        command.recipe.Remove(partOfCommand);
                        break;
                    default:
                        command.recipe.Remove(partOfCommand);
                        break;
                }
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
