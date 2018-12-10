﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterChefInfo
{
    /// <summary>
    /// Classe du chef de cuisine
    /// </summary>
    class MasterChef
    {
        public List<SectionChef> sectionChefs { get; set; }
        public List<Command> commandsToDo { get; set; }
        public int posX { get; set; }
        public int posY { get; set; }

        public MasterChef()
        {
            sectionChefs = new List<SectionChef> { };
            commandsToDo = new List<Command> { };

            sectionChefs.Add(new SectionChef(1));
            sectionChefs.Add(new SectionChef(2));
        }

    }
}
