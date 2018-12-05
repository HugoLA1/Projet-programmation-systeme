using System;
using System.Collections.Generic;
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
        Thread threadMH;

        /// <summary>
        /// Constructeur
        /// </summary>
        public MaitreHotelController(Model model)
        {
            this.model = model;
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
                    AssignToTable(groupClient);

                }
                Thread.Sleep(100);
            }
        }

        /// <summary>
        /// Methode pour trouver une table libre et assez grande pour acceuilir les clients
        /// </summary>
        public void AssignToTable(GroupClient groupClient)
        {
            for (int s = 0; s < model.dinnerRoom.squares.Count; s++)
            {
                for (int l = 0; l < model.dinnerRoom.squares[s].lines.Count; l++)
                {
                    for (int t = 0; t < model.dinnerRoom.squares[s].lines[l].tables.Count; t++)
                    {
                        if((groupClient.clientNumber == model.dinnerRoom.squares[s].lines[l].tables[t].places) && (model.dinnerRoom.squares[s].lines[l].tables[t].groupClient == null))
                        {
                            groupClient.dishState = DishState.WaitToBePlaced;
                        }
                    }
                }
            }
        }
    }
}
