using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Gas_station.DataAccess.MySql
{
    internal class MySqlUtil
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["MySqlHciGasStation"].ConnectionString;
    
        public static MySqlConnection GetConnection()
        {
            Console.WriteLine("2222");
            var conn = new MySqlConnection(connectionString);
            conn.Open();
            return conn;
        }

        public static void CloseQuietly(MySqlConnection conn)
        {
            try
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            catch { }
        }

        public static void CloseQuietly(MySqlDataReader reader)
        {
            try
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
            catch { }
        }

        public static void CloseQuietly(MySqlDataReader reader, MySqlConnection conn)
        {
            CloseQuietly(reader);
            CloseQuietly(conn);
        }
    }
}
