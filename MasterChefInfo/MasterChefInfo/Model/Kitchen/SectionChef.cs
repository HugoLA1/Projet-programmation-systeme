using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterChefInfo
{
    /// <summary>
    /// Classe du chef de section
    /// </summary>
    class SectionChef : ISubject
    {
        List<IObserver> observers;
        public bool isAvailable { get; set; }
        public int ID;

        public SectionChef(int ID)
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
                observer.Update("sectionChef", ID, track);
            }
        }

    }

}
