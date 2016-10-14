using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace WebShop
{
    public partial class ShoppingCart : System.Web.UI.Page
    {
        public List<CartItem> list;
        public Cart cart;


        protected void Page_PreRender(object sender, EventArgs e)
        {


            if (cart != null)
            {
                cartDiv.Controls.Clear();
                if (cart.cart.Count < 1)
                {
                    cartDiv.Controls.Add(cart.CartEmpty);
                }
                else
                {
                    cartDiv.Controls.Add(cart.GetCart());
                }
            }

            else
            {
                Cart cart = new Cart();
                Session["Cart"] = cart;
                cartDiv.Controls.Add(cart.CartEmpty);
            }


            if (cart != null)
                cart.BuildCart();
            Session["Cart"] = cart;

            TotalPrice.InnerText = "Total Price: " + cart.GetTotalPrice().ToString() + " kr";
        }

       
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            { 
            cart = Session["cart"] as Cart;
            if (cart != null)
            {

                if (cart.cart.Count < 1)
                {
                    cartDiv.Controls.Add(cart.CartEmpty);
                }
                else
                {
                    cartDiv.Controls.Add(cart.GetCart());
                }
            }

            else
            {
                Cart newCart = new Cart();
                Session["Cart"] = cart;
                cartDiv.Controls.Add(newCart.CartEmpty);
            }
            }

        }
        protected void Page_UnLoad(object sender, EventArgs e)
        {
            cart = Session["cart"] as Cart;
        }


        protected void ToCart_Click(object sender, EventArgs e)
        {

            Response.Redirect("Kassan.aspx");
        }
        




    }
}