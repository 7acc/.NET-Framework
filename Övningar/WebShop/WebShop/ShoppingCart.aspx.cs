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
            list = cart.cart;
            CartGrid.DataSource = list;
            CartGrid.DataBind();


        }

        protected void CartGrid_OnRowDataBound(object sender, GridViewRowEventArgs e)
        {
            for (int i = 0; i < CartGrid.Rows.Count; i++)
            {
                Image Thumb = CartGrid.Rows[i].FindControl("img") as Image;
                Thumb.ImageUrl = list[i].ThumbNail;
                Thumb.AlternateText = "im here";

            }
        }     
    }
}