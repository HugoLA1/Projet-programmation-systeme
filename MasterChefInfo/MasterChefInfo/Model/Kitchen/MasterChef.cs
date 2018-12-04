using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterChefInfo
{
    class MasterChef
    {

        public List<SectionChef> sectionChefs { get; set; }
        public List<Command> commandsToDo { get; set; }
        public int posX { get; set; }
        public int posY { get; set; }

        public MasterChef()
        {
            sectionChefs.Add(new SectionChef());
            sectionChefs.Add(new SectionChef());
        }

    }
}
