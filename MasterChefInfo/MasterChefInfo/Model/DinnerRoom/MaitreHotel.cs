using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterChefInfo
{
    /// <summary>
    /// Classe du maitre d'hotel
    /// </summary>
    class MaitreHotel : ISubject
    {
        private List<IObserver> observers;
        public int posX { get; set; }
        public int posY { get; set; }
    

        public MaitreHotel() {
            observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void UnregisterObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers(int moneytotal)
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(moneytotal);
            }
        }

        public void NotifyObservers(List<Point> track)
        {
            throw new NotImplementedException();
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
