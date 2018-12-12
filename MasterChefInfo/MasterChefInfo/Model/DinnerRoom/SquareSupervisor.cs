using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterChefInfo
{
    /// <summary>
    /// La classe des SuperVisor (Positions et disponibiblité)
    /// </summary>
    class SquareSupervisor : ISubject
    {
        private List<IObserver> observers;
        public bool isAvailable { get; set; }
        public int sqr;
        public int ID;

        public SquareSupervisor(int ID, int sqr)
        {
            observers = new List<IObserver>();
            isAvailable = true;
            this.sqr = sqr;
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
                observer.Update("squareSupervisor" + sqr.ToString(), ID, track);
            }
        }

        public void NotifyObservers(List<Point> track, Table table)
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(track, table);
            }
        }
    }
}
