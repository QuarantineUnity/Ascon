using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ascon
{
    static class DB
    {
        public static string conString;

        // Подключение к базе данных

        public static SqlConnection con;

        public static void ConnectToDatabase()
        {
            con = new SqlConnection(conString);
        }

        // Открытие подключения

        public static void openConnection()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }

        // Закрытие подключения

        public static void closeConnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }

        // Запрос подключения

        public static SqlConnection getConnection()
        {
            return con;
        }
    }
}
