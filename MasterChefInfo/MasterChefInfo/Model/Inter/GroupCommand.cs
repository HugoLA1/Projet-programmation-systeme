using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterChefInfo
{
    class GroupCommand
    {
        /// <summary>
        /// Classe des commandes de groupe
        /// </summary>
        public List<Command> commands { get; set; }
        public int nbCommand { get; set; }
        public Table table { get; set; }

        public GroupCommand(int nbCommand, Table table)
        {
            this.nbCommand = nbCommand;
            commands = new List<Command> { };
            this.table = table;
        }
    }
}
