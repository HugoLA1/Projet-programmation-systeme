using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterChefInfo
{
    /// <summary>
    /// Classe qui contôle les groupes de clients
    /// </summary>
    class GroupClientController
    {
        public void ThreadEatApetizer(GroupClient groupClient)
        {
            Thread threadCEA = new Thread(() => EatApetizer(30, groupClient));
            threadCEA.Start();
        }

        public void ThreadEatDish(GroupClient groupClient)
        {
            Thread threadCEDi = new Thread(() => EatDish(60, groupClient));
            threadCEDi.Start();
        }

        public void ThreadEatDesert(GroupClient groupClient)
        {
            Thread threadCEDe = new Thread(() => EatDesert(30, groupClient));
            threadCEDe.Start();
        }

        public void ThreadChoseMenu(GroupClient groupClient)
        {
            Thread threadCCM = new Thread(() => ChoseMenu(5, groupClient));
            threadCCM.Start();
        }

        public void EatApetizer(int second, GroupClient groupClient)
        {
            Thread.Sleep(second * 1000);
            groupClient.dishState = DishState.FinishedApetizer;
            MessageBox.Show("FinishedApetizer");
        }

        public void EatDish(int second, GroupClient groupClient)
        {
            Thread.Sleep(second * 1000);
            groupClient.dishState = DishState.FinishedDish;
            MessageBox.Show("FinishedDish");

        }

        public void EatDesert(int second, GroupClient groupClient)
        {
            Thread.Sleep(second * 1000);
            groupClient.dishState = DishState.FinishedDesert;
            MessageBox.Show("FinishedDesert");

        }

        public void ChoseMenu(int second, GroupClient groupClient)
        {
            Thread.Sleep(second * 1000);
            groupClient.dishState = DishState.Choosed;
            MessageBox.Show("Choosed");

        }
    }
}
