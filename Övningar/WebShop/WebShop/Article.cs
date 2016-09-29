using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace WebShop
{

    public class Article
    {
        public int ArticleID { get; set; }
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public string BigPicture { get; set; }
        public string ThumbNail { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }

        public Dictionary<string, int> Sizes { get; set; }


        public static List<Article> GetListOfArticles(DataTable DT)
        {
            List<Article> list = new List<Article>();

            for (int i = 0; i < DT.Rows.Count; i++)
            {
                var dict = new Dictionary<string, int>();

                dict.Add("S", (int)DT.Rows[i]["S"]);
                dict.Add("M", (int)DT.Rows[i]["M"]);
                dict.Add("L", (int)DT.Rows[i]["L"]);

                list.Add(new Article
                {
                    ArticleID = (int)DT.Rows[i]["ArticleID"],
                    ProductID = (int)DT.Rows[i]["ProductID"],
                    Name = (string)DT.Rows[i]["ProductName"],
                    Brand = (string)DT.Rows[i]["BrandName"],
                    Color = (string)DT.Rows[i]["Color"],
                    BigPicture = ((byte[])DT.Rows[i]["BigPicture"]).ConvertToURL(),
                    ThumbNail = ((byte[])DT.Rows[i]["ThumbNail"]).ConvertToURL(),
                    Category = (string)DT.Rows[i]["CategoryName"],
                    Description = (string)DT.Rows[i]["Description"],
                    Sizes = dict                    
                });

            }
            return list;
        }


    }
}