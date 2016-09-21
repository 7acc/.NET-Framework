using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DBTest
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageURL { get; set; }
        public int Brand { get; set; }
        static SqlConnection Pconnection { get; set; }

        public Product()
        {

        }

        public Product(int id, string name, string description, decimal Price, string productImage, int brand)
        {
            this.ID = id;
            this.Name = name;
            this.Description = description;
            this.Price = Price;
            this.ImageURL = productImage;
            this.Brand = brand;
        }



    }

}
