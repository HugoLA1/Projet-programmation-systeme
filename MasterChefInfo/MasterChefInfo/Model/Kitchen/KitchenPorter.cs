using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterChefInfo
{
    /// <summary>
    /// Classe du plongeur
    /// </summary>
    class KitchenPorter : ISubject
    {
        private string name;

        private List<IObserver> observers;
        public int posX { get; set; }
        public int posY { get; set; }

        public KitchenPorter(int ID)
        {
            observers = new List<IObserver>();
            switch (ID)
            {
                case 5:
                    name = "KitchenPorter";
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
                //observer.Update(name, track);
            }
        }

        public void NotifyObservers(List<Point> track, Table table)
        {
            throw new NotImplementedException();
        }

        public void NotifyObservers(Table table, string type)
        {
            throw new NotImplementedException();
        }
    }
}
