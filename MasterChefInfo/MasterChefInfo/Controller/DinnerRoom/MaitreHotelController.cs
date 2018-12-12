using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterChefInfo
{   /// <summary>
    /// Classe du maitre d'hotel
    /// </summary>
    class MaitreHotelController
    {
        Model model;
        Form1 form;
        Thread threadMH;
        int money;

        /// <summary>
        /// Constructeur
        /// </summary>
        public MaitreHotelController(Model model, Form1 form)
        {
            this.model = model;
            this.form = form;
            money = new int();
            CreateThread();
        }

        /// <summary>
        /// Création du Thread du maitre d'hotel
        /// </summary>
        public void CreateThread()
        {
            threadMH = new Thread(new ThreadStart(WatchLoop));
            threadMH.Start();
        }

        /// <summary>
        /// Le maitre d'hotel observe si il y a des clients devant la porte et les assigne a leur table respective
        /// Il récupère aussi l'argents des clients.
        /// </summary>
        public void WatchLoop()
        {
            while (Thread.CurrentThread.IsAlive)
            {
                if(model.dinnerRoom.waitingGroupClients.Count > 0)
                {
                    GroupClient groupClient = model.dinnerRoom.waitingGroupClients[0];
                    model.dinnerRoom.waitingGroupClients.Remove(groupClient);
                    Console.WriteLine("Assigner une table");
                    AssignToTable(groupClient);
                }

                for (int s = 0; s < model.dinnerRoom.squares.Count; s++)
                {
                    for (int l = 0; l < model.dinnerRoom.squares[s].lines.Count; l++)
                    {
                        for (int t = 0; t < model.dinnerRoom.squares[s].lines[l].tables.Count; t++)
                        {
                            if((model.dinnerRoom.squares[s].lines[l].tables[t].groupClient != null) && (model.dinnerRoom.squares[s].lines[l].tables[t].groupClient.dishState == DishState.WaitNote))
                            {
                                Console.WriteLine("Récupérer argent");

                                money += model.dinnerRoom.squares[s].lines[l].tables[t].groupClient.finalPrice;
                                model.dinnerRoom.squares[s].lines[l].tables[t].groupClient = null;
                                model.dinnerRoom.maitreHotel.NotifyObservers(money);
                            }
                        }
                    }
                }
                Thread.Sleep(100);
            }
        }

        /// <summary>
        /// Methode pour trouver une table libre et assez grande pour acceuilir les clients
        /// </summary>
        public void AssignToTable(GroupClient groupClient)
        {
            bool getOutOfLoop = false;
            foreach(Square square in model.dinnerRoom.squares)
            {
                foreach(Line line in square.lines)
                {
                    foreach(Table table in line.tables)
                    {
                        if((groupClient.clientNumber <= table.places) && (table.groupClient == null))
                        {
                            table.groupClient = groupClient;
                            model.dinnerRoom.waitingGroupClients.Remove(groupClient);
                            groupClient.dishState = DishState.Waiting;
                            form.CreateSpriteClient(table);
                            groupClient.dishState = DishState.WaitToBePlaced;
                            getOutOfLoop = true;
                            if (getOutOfLoop) break;
                        }
                    }
                    if (getOutOfLoop) break;
                }
                if (getOutOfLoop) break;
            }
        }
    }
}
