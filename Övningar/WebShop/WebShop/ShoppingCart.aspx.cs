using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebShop
{
    public partial class ShoppingCart : System.Web.UI.Page
    {
      public List<CartItem> list;
        protected void Page_Load(object sender, EventArgs e)
        {
            var cart = (Cart)Session["Cart"];

            cartDiv.Controls.Add(cart.GetCart());
            TotalPrice.InnerText = "Total Price: " + cart.GetTotalPrice().ToString() + " kr";
        }


          
    }
}