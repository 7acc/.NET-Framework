using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DBConnect
{
    class Program
    {
        static void Main(string[] args)
        {
            DBconnect db = new DBconnect();
            Console.WriteLine(db.GetNameById(4));
            Console.ReadKey();
        }
    }
    class DBconnect
    {
        public string ConnectionString { get; set; }
        public SqlConnection Connection { get; set; }
        public DBconnect()
        {
            ConnectionString = @"Data Source = (Local); Initial Catalog = WebShop; Integrated Security = True";
            Connection = new SqlConnection();
            
        }

        public string GetNameById(int ID)
        {
            using (SqlConnection connectio = new SqlConnection(ConnectionString))
            {

                string name = string.Empty;
                string sql = $"SELECT ProductName From Product Where ProductID = @ID";

                SqlCommand cmd = new SqlCommand(sql, connectio);
                cmd.Parameters.Add(new SqlParameter("@ID", ID));
                connectio.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    name = (string)reader[0];
                }

                Connection.Close();
                return name;
            }
        }

    }
}
