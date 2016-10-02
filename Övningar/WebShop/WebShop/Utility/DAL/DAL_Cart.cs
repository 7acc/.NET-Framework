using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace WebShop
{
    public class DAL_Cart : DAL
    {
        public DataTable GetCart(string UserID)
        {

            OpenConnection(ConnectionString);
            string sql = "";


            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, Connection))
            {
                DataTable data = new DataTable();
                dataAdapter.Fill(data);

                return data;

            }
        }

        public void SaveCart()
        {
            throw new NotImplementedException();
        }

      
    }
}