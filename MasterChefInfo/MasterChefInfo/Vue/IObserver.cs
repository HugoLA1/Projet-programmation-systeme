using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterChefInfo
{
    /// <summary>
    /// Classe de l'observer
    /// </summary>
    interface IObserver
    {
        void Update(String name,List<Point> track);
    }
}
