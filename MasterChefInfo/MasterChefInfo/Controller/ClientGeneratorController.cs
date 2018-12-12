using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
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
        readonly Model model;
        Random rnd = new Random();

        public ClientGeneratorController (Model model)
        {
            this.model = model;
        }

        public GroupClient CreateNewGroupClient()
        {
            /// Génére un nombre aléatoire de client entre 1 et 10
            int randomNumber = rnd.Next(1, 11);
            //int randomNumber = 8;

            DataTable temp = new DataTable();
            DataRow tempRow;
            MySqlCommand commandRequest = new MySqlCommand();
            GroupClient groupClient = new GroupClient(randomNumber);

            for (int ctr = 0; ctr < randomNumber; ctr++)
            {
                groupClient.clients[ctr] = new Client();
                
                /// Selectionne une entrée pour le client (Nom+instructions+prix)
                commandRequest.CommandText = "SELECT * FROM recette WHERE categorie = 'Entrée' ORDER BY RAND() LIMIT 1";
                temp = model.BDD.ExecuteRequest(commandRequest);
                groupClient.clients[ctr].appetizer = new Command();
                tempRow = temp.Rows[0];
                groupClient.clients[ctr].appetizer.name = tempRow["recetteNom"].ToString();
                groupClient.clients[ctr].appetizer.recipe = new List<string>(tempRow["instructions"].ToString().Split('-'));
                groupClient.finalPrice +=(int) double.Parse(tempRow["prix"].ToString());

                /// Selectionne un plat pour le client (Nom+instructions+prix)
                commandRequest.CommandText = "SELECT * FROM recette WHERE categorie = 'Plat' ORDER BY RAND() LIMIT 1";
                temp = model.BDD.ExecuteRequest(commandRequest);
                groupClient.clients[ctr].dish = new Command();
                tempRow = temp.Rows[0];
                groupClient.clients[ctr].dish.name = tempRow["recetteNom"].ToString();
                groupClient.clients[ctr].dish.recipe = new List<string>(tempRow["instructions"].ToString().Split('-'));
                groupClient.finalPrice += (int)double.Parse(tempRow["prix"].ToString());

                /// Selectionne un dessert pour le client (Nom+instructions+prix)
                commandRequest.CommandText = "SELECT * FROM recette WHERE categorie = 'Dessert' ORDER BY RAND() LIMIT 1";
                temp = model.BDD.ExecuteRequest(commandRequest);
                groupClient.clients[ctr].desert = new Command();
                tempRow = temp.Rows[0];
                groupClient.clients[ctr].desert.name = tempRow["recetteNom"].ToString();
                groupClient.clients[ctr].desert.recipe = new List<string>(tempRow["instructions"].ToString().Split('-'));
                groupClient.finalPrice +=(int) double.Parse(tempRow["prix"].ToString());
            }
            return groupClient;
        }
    }
}
