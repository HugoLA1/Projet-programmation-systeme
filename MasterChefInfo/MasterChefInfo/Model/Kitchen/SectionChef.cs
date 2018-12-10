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
        public int posX { get; set; }
        public int posY { get; set; }

        public bool isAvailable { get; set; }

        String name;

        List<IObserver> observers;

        public SectionChef(int ID)
        {
            isAvailable = true;

                observers = new List<IObserver>();

                switch (ID)
                {
                    case 1:
                        name = "SC1";
                        break;
                    case 2:
                        name = "SC2";
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
