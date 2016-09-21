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

namespace DBTest
{
    public class DBconnect
    {
        public string ConnectionString { get; set; }
        public SqlConnection Connection { get; set; }

        public DBconnect()
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
        public string ConvertByteToURl(byte[] array)
        {
           
            string base64String = Convert.ToBase64String(array, 0, array.Length);

            string url = "data:image/jpg;base64," + base64String;
            return url;
        }
        public List<Product> GetProductsByCategory(int categoryID)
        {
            OpenConnection(ConnectionString);
            string sql = "SELECT * From Product Where CategoryID = '" + categoryID + "'";
            List<Product> Products = new List<Product>();

            using (SqlCommand command = new SqlCommand(sql, Connection))
            {
                Image image;
                SqlDataReader DR = command.ExecuteReader();
                while (DR.Read())
                {

                    byte[] imgData = (byte[])DR["ProductIMG"];
                    using (MemoryStream ms = new MemoryStream(imgData))
                    {
                        image = Image.FromStream(ms);

                    }


                    Products.Add(new Product
                    {
                        ID = (int)DR["ProductID"],
                        Name = (string)DR["Name"],
                        Description = (string)DR["Description"],
                        Price = (decimal)DR["Price"],
                        ProductImage = ConvertByteToURl((byte[])DR)
                        Brand = (int)DR["BrandID"]

                    });
                }
                return Products;
            }

        public DataTable GetProductsByCategory()
        {
            OpenConnection(ConnectionString);
            string sql = "SELECT ProductIMG, Name From Product";
            List<Product> Products = new List<Product>();

            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, Connection))
            {
                DataTable data = new DataTable();

                dataAdapter.Fill(data);

                return data;

            }
        }
    }
}
