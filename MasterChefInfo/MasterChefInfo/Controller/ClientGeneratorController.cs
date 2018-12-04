using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace MasterChefInfo
{
    /// <summary>
    /// La classe permet de créer un groupe de clients allant de 1 à 10, puis pour chaque client elle lui attribut 
    /// une entrée, un plat et un dessert et les instructions associées. Elle récupére aussi le prix de la note
    /// totale du groupe.
    /// </summary>
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
            /// Génére un nombre aléatoire de client entre 1 et 10
            int randomNumber = 0;
            randomNumber = rnd.Next(1, 11);
            GroupClient groupClient = new GroupClient();
            groupClient.clientNumber = randomNumber;
            for (int ctr = 1; ctr <= randomNumber; ctr++)
            {
                /// Selectionne une entrée pour le client (Nom+instructions+prix)
                groupClient.clients[ctr] = new Client();
                MySqlCommand commandRequestAppetizer = new MySqlCommand("SELECT * FROM `recette` WHERE categorie = \"Entrée\" ORDER BY RAND() LIMIT 1");
                DataTable temp = this.model.BDD.ExecuteRequest(commandRequestAppetizer);
                Command command = new Command();
                DataRow tempRow = temp.Rows[0];
                command.name= tempRow["recetteNom"].ToString();
                command.recipe = new List<string>(tempRow["instructions"].ToString().Split(';'));
                groupClient.finalPrice += int.Parse(tempRow["prix"].ToString());
                groupClient.clients[ctr].appetizer = command;

                /// Selectionne un plat pour le client (Nom+instructions+prix)
                MySqlCommand commandRequestDish = new MySqlCommand("SELECT * FROM `recette` WHERE categorie = \"Plat\" ORDER BY RAND() LIMIT 1");
                temp = this.model.BDD.ExecuteRequest(commandRequestDish);
                tempRow = temp.Rows[0];
                command.name = tempRow["recetteNom"].ToString();
                command.recipe = new List<string>(tempRow["instructions"].ToString().Split(';'));
                groupClient.finalPrice += int.Parse(tempRow["prix"].ToString());
                groupClient.clients[ctr].dish = command;

                /// Selectionne un dessert pour le client (Nom+instructions+prix)
                MySqlCommand commandRequestDesert = new MySqlCommand("SELECT * FROM `recette` WHERE categorie = \"Dessert\" ORDER BY RAND() LIMIT 1");
                temp = this.model.BDD.ExecuteRequest(commandRequestDesert);
                tempRow = temp.Rows[0];
                command.name = tempRow["recetteNom"].ToString();
                command.recipe = new List<string>(tempRow["instructions"].ToString().Split(';'));
                groupClient.finalPrice = int.Parse(tempRow["prix"].ToString());
                groupClient.clients[ctr].desert = command;
            }
            return groupClient;
        }
    }
}
