using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MasterChefInfo
{
    class MasterChefController
    {
        public Model model;
        public SectionChefController sectionChefController;

        Thread threadMC;

        public MasterChefController(Model model, SectionChefController sectionChefController)
        {
            this.model = model;
            this.sectionChefController = sectionChefController;
            CreateThread();
        }

        public void CreateThread()
        {
            threadMC = new Thread(new ThreadStart(WatchLoop));
            threadMC.Start();
        }

        public void WatchLoop()
        {
            while (Thread.CurrentThread.IsAlive)
            {
                bool getOutOfLoop = false;
                if (model.kitchen.cookingRoom.masterChef.commandsToDo.Count > 0)
                {
                    foreach(SectionChef sectionChef in model.kitchen.cookingRoom.masterChef.sectionChefs)
                    {
                        if (sectionChef.isAvailable)
                        {
                            sectionChef.isAvailable = false;
                            Command tempCommand = model.kitchen.cookingRoom.masterChef.commandsToDo[0];
                            model.kitchen.cookingRoom.masterChef.commandsToDo.Remove(tempCommand);
                            Thread threadGO = new Thread(() => GiveOrder(sectionChef, tempCommand));
                            getOutOfLoop = true;
                            threadGO.Start();
                        }
                        if (getOutOfLoop) break;
                    }
                }
                Thread.Sleep(100);
            }
        }

        public void GiveOrder(SectionChef sectionChef, Command command)
        {
            Command newCommand = sectionChefController.MakePartOfCommand(sectionChef, command);

            if(newCommand.recipe.Count == 1)
            {
                foreach(GroupCommand groupCommand in model.counter.waitingGroupCommand)
                {
                    if (groupCommand.table == command.table)
                    {
                        groupCommand.commands.Add(command);
                    }
                }
            }else
            {
                model.kitchen.cookingRoom.masterChef.commandsToDo.Add(newCommand);
            }
            sectionChef.isAvailable = true;
        }
    }
}
