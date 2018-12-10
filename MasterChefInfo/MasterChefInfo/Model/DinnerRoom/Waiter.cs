using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterChefInfo
{
    /// <summary>
    /// Classe des serveurs
    /// </summary>
    class Waiter : ISubject
    {

        private string name;

        private List<IObserver> observers;

        public bool isAvailable;

        /// <summary>
        /// Contient la disponibilité des serveurs
        /// </summary>
        public Waiter(int ID)
        {
            observers = new List<IObserver>();

            switch (ID)
            {
                case 1:
                    name = "Waiter1";
                    break;
                case 2:
                    name = "Waiter2";
                    break;
                case 3:
                    name = "Waiter3";
                    break;
                case 4:
                    name = "Waiter4";
                    break;
            }
            isAvailable = true;
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void UnregisterObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers(List<Point> track)
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(name, track);
            }
        }
    }
}
