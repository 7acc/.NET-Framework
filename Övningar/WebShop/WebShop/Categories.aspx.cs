using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebShop
{
    public partial class Categories : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            DBconnect DB = new DBconnect();
            string cat = (string)Session["SelectedCat"];

            var DT = DB.GetProductsByCategory(cat);

            Page.PrintProducts(DT);

        }
    }
}