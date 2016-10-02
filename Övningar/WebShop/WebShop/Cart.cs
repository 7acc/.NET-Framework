using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebShop
{
    public class Cart
    {
        public List<CartItem> cart{ get; set; }
        public Table CarTable { get; set; }

        public Cart()
        {
            cart = new List<CartItem>();
        }

        public void AddItem(Article article, string size, int quantity)
        {
            
            if (cart.Any(x => x.ArticleID == article.ArticleID &&  x.Size == size))
            {
                CartItem item = cart.Find(x => x.ArticleID == article.ArticleID);
                item.Quantity ++;
            }
            else
            {
                cart.Add(new CartItem(article,size));
            }                       
        }
        public void BuildCart

       
        

    }
}