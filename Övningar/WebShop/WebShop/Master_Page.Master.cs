using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebShop
{
    public partial class Master_Page : System.Web.UI.MasterPage
    {
        protected void Page_PreRender(object sender, EventArgs e)
        {
            CartUpdate();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        public void Category_onclick(object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)sender;
            var category = btn.ID;
            Session["SelectedCat"] = category.Substring(3);
            Response.Redirect("Categories.aspx");
        }

        public void CartUpdate()
        {
            var cart = (Cart)Session["Cart"];
            if (cart != null)
            {
                cartCount.Text = cart.cart.Count().ToString();
                cartTotal.Text = cart.GetTotalPrice().ToString();
            }
            else
            {
                cartCount.Text = "0";
            }
        }
    }
}