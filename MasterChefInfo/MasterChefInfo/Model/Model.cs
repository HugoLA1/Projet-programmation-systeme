using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterChefInfo
{
    /// <summary>
    /// Classe du model
    /// </summary>
    class Model
    {

        public DataBaseExchanger BDD { get; set; }
        public RequestMapper requestMapper { get; set; }
        public DinnerRoom dinnerRoom { get; set; }
        public Kitchen kitchen { get; set; }
        public Counter counter { get; set; }
        public Sprite sprite { get; set; }

        public Model()
        {
            BDD = new DataBaseExchanger();
            requestMapper = new RequestMapper();
            dinnerRoom = new DinnerRoom();
            kitchen = new Kitchen();
            counter = new Counter();
        }
    }
}
