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
    public class DAL_Products : DAL
    {
        public DataTable GetProductsByCategory(string id)
        {
            OpenConnection(ConnectionString);
            string sql = /*$"SELECT * From Product WHERE CategoryID = '{ID}'";*/$"SELECT * From Product";


            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, Connection))
            {
                DataTable data = new DataTable();
                dataAdapter.Fill(data);

                return data;

            }
        }
    }
}