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

        public GroupCommand(Table table)
        {
            nbCommand = table.groupClient.clientNumber;
            commands = new List<Command> { };
            this.table = table;
        }
    }
}
