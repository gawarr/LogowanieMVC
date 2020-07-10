using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LogowanieMVC.Models
{
    public class LogIn
    {
        public static string login;
        public static void EnterData()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Praktyki\\source\\repos\\LogowanieMVC\\LogowanieMVC\\App_Data\\BAZA.mdf;Integrated Security=True";
            string query = "SELECT Login,  From dbo.UsersLoginData WHERE Id = @id";
            int id = 1;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", id);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();

                login = (string)reader[0];
            }
        }
        public static void Check()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Praktyki\\source\\repos\\LogowanieMVC\\LogowanieMVC\\App_Data\\BAZA.mdf;Integrated Security=True";
            string query = "SELECT Login,  From dbo.UsersLoginData WHERE Id = @id";
            int id = 1;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", id);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();

                login = (string)reader[0];
            }
        }
    }
}
