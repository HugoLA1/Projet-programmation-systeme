using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace MasterChefInfo
{
    class ClientGeneratorController
    {
        Model model;
        Random rnd = new Random();

        public ClientGeneratorController (Model model)
        {
            this.model = model;
        }
        public GroupClient CreateNewGroupClient()
        {
            int randomNumber = 0;
            randomNumber, rnd.Next(1, 11);

            for (int ctr = 1; ctr <= randomNumber; ctr++)
            {
                MySqlCommand commandRequestAppetizer = new MySqlCommand("SELECT * FROM `recette` WHERE categorie = \"Entrée\" ORDER BY RAND() LIMIT 1");
                DataTable temp = this.model.BDD.ExecuteRequest(commandRequestAppetizer);


                MySqlCommand commandRequestDish = new MySqlCommand("SELECT * FROM `recette` WHERE categorie = \"Plat\" ORDER BY RAND() LIMIT 1");
                DataTable temp2 = this.model.BDD.ExecuteRequest(commandRequestDish);

                MySqlCommand commandRequestDesert = new MySqlCommand("SELECT * FROM `recette` WHERE categorie = \"Dessert\" ORDER BY RAND() LIMIT 1");
                DataTable temp3 = this.model.BDD.ExecuteRequest(commandRequestDesert);
            }
            return ;
        }


    }
}
