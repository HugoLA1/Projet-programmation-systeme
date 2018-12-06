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
                    break;
                case "Four":
                    MoveToBakery(sectionChef);
                    break;
                case "Mélanger":
                    MoveToStorageRoom(sectionChef);
                    break;
            }

            command.recipe.Remove(partOfCommand);
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
