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
        private List<IObserver> observers;
        public bool isAvailable;
        private int ID;

        /// <summary>
        /// Contient la disponibilité des serveurs
        /// </summary>
        public Waiter(int ID)
        {
            observers = new List<IObserver>();
            isAvailable = true;
            this.ID = ID;
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
                observer.Update("waiter", ID, track);
            }
        }

        public void NotifyObservers(List<Point> track, Table table)
        {
            throw new NotImplementedException();
        }

        public void NotifyObservers(Table table, string type)
        {
            foreach (IObserver observer in observers)
            {
                lock (table)
                {
                    observer.Update(table, type);
                }
            }
        }
    }
}
