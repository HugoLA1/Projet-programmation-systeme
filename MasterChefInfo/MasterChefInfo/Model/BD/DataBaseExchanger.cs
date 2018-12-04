using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterChefInfo
{
    public class DataBaseExchanger
    {
        private const String server = "localhost";
        private const String database = "prosit_5.2.8";
        private const String uid = "root";  //Ici rien de bien compliqué on récupère les information de connection
        private const String password = "";

        private const String fullConnectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
        //Pour les concaténé ici sous un format bien précis
        public MySqlConnection Connection()
        {
            return new MySqlConnection(fullConnectionString); //methode retournant la connection a la BDD
        }

        public DataTable ExecuteRequest(MySqlCommand command) //Methode pour executer une requete a partir d'une SqlCommand
        {
            using (MySqlConnection connection = Connection())
            {
                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command); //Using ici pour la destruction de la connection aprés utilisation
                command.Connection = connection;
                DataTable table = new DataTable();
                //MessageBox.Show(command.CommandText);  //Trés trés utile ce messagebox pour le debug
                adapter.Fill(table); //On récupère le résultat de la requete sur la base de donnée sous forme d'une DataTable
                connection.Close();  //On oublie pas de close la connection /!\ et surtout pas de l'open avant de faire du traitement aussi
                return table; //On la renvoie la ou la methode a été appelé
            }
        }

        public void ExecuteAction(MySqlCommand command)
        {
            using (MySqlConnection connection = Connection())
            {
                connection.Open();                          //Ducoup pas besoin de récupérer une table ou quoi que ce soit on envoi juste une requete
                command.Connection = connection;
                //MessageBox.Show(command.CommandText);     //Trés trés utile ce messagebox pour le debug
                command.ExecuteNonQuery();
                connection.Close();  //On oublie pas de close la connection /!\ et surtout pas de l'open avant de faire du traitement aussi
            }
        }
    }
}
