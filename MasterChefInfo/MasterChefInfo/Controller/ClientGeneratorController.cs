using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterChefInfo
{
    class ClientGeneratorController
    {
        Model model;

        public ClientGeneratorController (Model model)
        {
            this.model = model;
        }
        public GroupClient CreateNewGroupClient()
        {
            this.model.BDD.ExecuteRequest("");
            return;
        }


    }
}
