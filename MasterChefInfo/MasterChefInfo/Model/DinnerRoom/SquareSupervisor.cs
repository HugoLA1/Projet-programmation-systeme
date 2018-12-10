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
        public bool isAvailable { get; set; }

        public string name;

        private List<IObserver> observers;


        public SquareSupervisor(int ID)
        {
            observers = new List<IObserver>();
            isAvailable = true;

            switch (ID)
            {
                case 1:
                    name = "SS1";
                    break;
                case 2:
                    name = "SS2";
                    break;
            }
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
