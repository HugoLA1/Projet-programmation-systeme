using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MasterChefInfo
{
    /// <summary>
    /// Classe qui contrôle le plongeur
    /// </summary>
    class KitchenPorterController : ISubject
    {
        Model model;
        Thread threadK;
        private List<IObserver> observers;
        public KitchenPorterController()
        {

            this.model = model;
            CreateThread();
        }
        public void MoveToDishWater(DishWasher dishWasher)
        {
            dishWasher.NotifyObservers(model.kitchen.cleanningRoom.dishWasher);
        }

        public void MoveToWashingMachine()
        {

        }

        public void WashUstensil(List<Ustensil> useUstensil)
        {
            if (model.counter.useUsentils[0] != null)
            {
                MoveToCounter(model.counter.counterPoint);
                MoveToDishWater(model.kitchen.cleanningRoom.dishWasher);
                StartDishWasher(useUstensil);
            }
        }

        private void MoveToCounter(Point counterPoint)
        {
            
        }

        public void StartDishWasher(List<Ustensil> ustensils)
        {
            Task taskD;
            taskD = new Task(() => WatchLoop());
            taskD.Start();
            Thread.Sleep(6000);
        }

        public void StartWashingMachine(List<Ustensil> ustensils)
        {

        }

        /// <summary>
        /// Créer un thread
        /// </summary>
        public void CreateThread()
        {

            threadK = new Thread(() => WatchLoop());
            threadK.Start();
        }

        public void WatchLoop()
        {
            throw new NotImplementedException();
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void UnregisterObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers(List<Point> counter)
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(counter);
            }
        }
    }
}
