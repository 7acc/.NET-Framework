using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebShop
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ProductIMG { get; set; }
        public decimal Price { get; set; }
        public string brand { get; set; }

        public static List<Product> GetListOfProducts(DataTable dt)
        {
            List<Product> list = new List<Product>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                list.Add(new Product
                {
                    ID = (int)dt.Rows[i]["productID"],
                    Name = (string)dt.Rows[i]["Name"],
                    ProductIMG = ConvertByteToURl((byte[])dt.Rows[i]["ProductIMG"]),
                    Price = (decimal)dt.Rows[i]["Price"],
                    //brand = (string)DT.Rows[i]["brand"],
                });
            }
            return list;

        }

        public static string ConvertByteToURl(byte[] array)
        {
            string base64String = Convert.ToBase64String(array, 0, array.Length);
            string url = "data:image/jpg;base64," + base64String;
            return url;
        }
    }
}