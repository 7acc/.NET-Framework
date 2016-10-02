using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace WebShop
{
    public class CartItem
    {

        public int ArticleID { get; set; }
        public int ProductID { get; set; }
        public string ThumbNail { get; set; }

        public string Name { get; set; }
        public string Brand { get; set; }

        public decimal Price { get; set; }
        public int Quantity  { get; set; }

        public string Color { get; set; }   
        public string Size { get; set; }

        public CartItem(Article article, string size)
        {
            this.ArticleID = article.ArticleID;
            this.ProductID = article.ArticleID;
            this.ThumbNail = article.ThumbNail;
           
            this.Name = article.Name;
            this.Brand = article.Brand;
            this.Price = article.Price;
            this.Color = article.Color;
            this.Size = size;

            this.Quantity = 1;
        }
        public CartItem(Article article, string size, int quantity)
        {
            this.ArticleID = article.ArticleID;
            this.ProductID = article.ArticleID;
            this.ThumbNail =  article.ThumbNail;
            this.Name = article.Name;
            this.Brand = article.Brand;
            this.Price = article.Price;
            this.Color = article.Color;
            this.Size = size;

            this.Quantity = quantity;
        }

    }
}