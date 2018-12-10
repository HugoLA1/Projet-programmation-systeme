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

        public SectionChef GetSectionChefAvailable()
        {
            return new SectionChef();
        }

        public Command MakePartOfCommand(SectionChef sectionChef, Command command)
        {
            string partOfCommand = command.recipe[0];

            Console.WriteLine(command.name);
            Console.WriteLine(partOfCommand);


            switch (partOfCommand)
            {
                case "Ajouter":
                    MoveToWorkSurface(sectionChef);
                    command.recipe.Remove(partOfCommand);
                    break;
                case "Four":
                    MoveToBakery(sectionChef);
                    command.recipe.Remove(partOfCommand);
                    break;
                case "Mélanger":
                    MoveToStorageRoom(sectionChef);
                    command.recipe.Remove(partOfCommand);
                    break;
                case "Servir":
                    command.recipe.Remove(partOfCommand);
                    break;
                default:
                    command.recipe.Remove(partOfCommand);
                    break;
            }

            return command;
                
        }

        public void MoveToBakery(SectionChef sectionChef)
        {

        }

        public void MoveToStorageRoom(SectionChef sectionChef)
        {

        }

        public void MoveToWorkSurface(SectionChef sectionChef)
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
