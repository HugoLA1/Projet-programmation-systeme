using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MasterChefInfo
{
    /// <summary>
    /// La classe permettant de controler les Square supervisor
    /// </summary>
    class SquareSupervisorController
    {
        public SquareSupervisor GetSquareSupervisor(Square square)
        {
            return new SquareSupervisor();
        }

        Model model;
        Thread threadS;

        public SquareSupervisorController(Model model)
        {
            this.model = model;
            CreateThread();
        }

        /// <summary>
        /// Créer un thread
        /// </summary>
        public void CreateThread()
        {
            threadS = new Thread(new ThreadStart(WatchLoop));
            threadS.Start();
        }

        /// <summary>
        /// Surveille les variations des états et lance la méthode adapté en fonction (Ici : Donner menus et les récupérer)
        /// </summary>
        public void WatchLoop()
        {
            while (Thread.CurrentThread.IsAlive)
            {
                for (int s = 0; s < model.dinnerRoom.squares.Count; s++)
                {
                        if (model.dinnerRoom.squares[s].squareSupervisor.isAvailable)
                        {
                            for (int l = 0; l < model.dinnerRoom.squares[s].lines.Count; l++)
                            {
                                for (int t = 0; t < model.dinnerRoom.squares[s].lines[l].tables.Count; t++)
                                {
                                    switch (model.dinnerRoom.squares[s].lines[l].tables[t].groupClient.dishState)
                                    {
                                        case DishState.WaitMenu:
                                            Thread threadSM = new Thread(() => SearchMenu(model.dinnerRoom.squares[s].lines[l].tables[t], model.dinnerRoom.squares[s].squareSupervisor);
                                            threadSM.Start();
                                            break;
                                        case DishState.Choosed:
                                            Thread threadCM = new Thread(() =>  CollectMenu(model.dinnerRoom.squares[s].lines[l].tables[t], model.dinnerRoom.squares[s].squareSupervisor);
                                            threadCM.Start();
                                            break;
                                        case DishState.WaitToBePlaced:
                                            Thread threadEC = new Thread(() => EscortClient(model.dinnerRoom.squares[s].lines[l].tables[t], model.dinnerRoom.squares[s].lines[l].tables[t].groupClient, model.dinnerRoom.squares[s].squareSupervisor));
                                            threadEC.Start();
                                            break;
                                }
                                }
                            
                        }
                    }
                }
                Thread.Sleep(100);
            }
        }
        /// <summary>
        /// Méthode permettant d'amener les clients aux tables
        /// </summary>
        public void EscortClient(Table table, GroupClient groupClient, SquareSupervisor squareSupervisor)
        {
            
        }

        /// <summary>
        /// Méthode permettant de faire bouger le personnage en fonction de la classe Clock
        /// </summary>
        public void MoveToTable(Table table)
        {

        }

        /// <summary>
        /// Méthode pour aller récupérer les menus et les amener aux clients
        /// </summary>
        public void SearchMenu (Table table, SquareSupervisor squareSupervisor)
        {

        }

        /// <summary>
        /// Méthode pour aller récupérer les menus des clients et prendre leur commande en même temps
        /// </summary>
        public void CollectMenu(Table table, SquareSupervisor squareSupervisor)
        {

        }

        /// <summary>
        /// Méthode pour récuperer la commande des clients
        /// </summary>
        public void GetCommande(Table table, SquareSupervisor squareSupervisor)
        {

        }
    }
}
