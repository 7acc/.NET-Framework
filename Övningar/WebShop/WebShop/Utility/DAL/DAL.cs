using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;

namespace WebShop
{
    public class DAL
    {

        public string ConnectionString { get; set; }
        public SqlConnection Connection { get; set; }
        public DAL()
        {
            ConnectionString = @"Data Source = (Local); Initial Catalog = WebShop; Integrated Security = True";
            Connection = new SqlConnection();
        }
        public void OpenConnection(string connectionString)
        {
            Connection.ConnectionString = connectionString;
            Connection.Open();
        }
        public void CloseConnection(SqlConnection connection)
        {
            connection.Close();
        }

    
    }
}