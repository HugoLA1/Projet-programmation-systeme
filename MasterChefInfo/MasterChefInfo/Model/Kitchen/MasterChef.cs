using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterChefInfo
{
    class MasterChef
    {

        List<SectionChef> sectionChefs;
        List<Command> commandsToDo;

        public MasterChef()
        {
            sectionChefs.Add(new SectionChef());
            sectionChefs.Add(new SectionChef());


        }

    }
}
