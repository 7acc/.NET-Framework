using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace WebShop
{
    public class DAL_article : DAL
    {
        public DataTable GetArticleById(string id)
        {

            OpenConnection(ConnectionString);
            string sql = "SELECT ArticleID, Article.ProductID, ProductName,Price, BrandName, Color, BigPicture, ThumbNail, Description, CategoryName, S,M,L " +
                      "FROM Article " +
                         "JOIN Product ON Article.ProductID = Product.ProductID " +
                         "JOIN Brand ON Product.BrandID = Brand.BrandID " +
                         "JOIN Images ON Article.ImageSetID = Images.ImageSetID " +
                         "JOIN Category ON Product.CategoryID = Category.CategoryID " +
                    "JOIN Colors ON Article.ColorID = Colors.ColorID " +
                    "left Outer JOIN Size On Article.SizeID = Size.SizeID "+
                    $"WHERE Product.CategoryID ='{id}'";
                 

            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, Connection))
            {
                DataTable data = new DataTable();
                dataAdapter.Fill(data);

                CloseConnection(Connection);
                return data;
            };
           
            
        }

        public void Update_InStore(int sizeId, string size, int amount)
        {
            OpenConnection(ConnectionString);
            string sql = "";

            using (SqlCommand cmd = new SqlCommand(sql, Connection))
            {
                
            }


        }
    }
}