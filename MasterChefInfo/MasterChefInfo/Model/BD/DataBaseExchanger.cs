using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace MasterChefInfo
{
    public class DataBaseExchanger
    {
        private const String server = "localhost";
        private const String database = "prosit_5.2.8";
        private const String uid = "root";
        private const String password = "";

        private const String fullConnectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
       
        public MySqlConnection Connection()
        {
            return new MySqlConnection(fullConnectionString);
        }

        public DataTable ExecuteRequest(MySqlCommand command)
        {
            using (MySqlConnection connection = Connection())
            {
                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command); 
                command.Connection = connection;
                DataTable table = new DataTable();
                
                adapter.Fill(table); 
                connection.Close();  
                return table; 
            }
        }

        public void ExecuteAction(MySqlCommand command)
        {
            using (MySqlConnection connection = Connection())
            {
                connection.Open();
                command.Connection = connection;
                //MessageBox.Show(command.CommandText);     //Trés trés utile ce messagebox pour le debug
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
