using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebShop
{
    public class DAL_article : DAL
    {
        public DataTable GetArticleById(string id)
        {
            
            OpenConnection(ConnectionString);
            string sql = /*$"SELECT * From Product WHERE CategoryID = '{ID}'";*/$"SELECT * FROM Article WHERE ProductID = '{id}' GROUP BY size";


            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, Connection))
            {
                DataTable data = new DataTable();
                dataAdapter.Fill(data);

                return data;

            }
    }
}