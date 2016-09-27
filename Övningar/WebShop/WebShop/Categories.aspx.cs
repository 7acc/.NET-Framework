using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            DAL_Products DB = new DAL_Products();
            string cat = (string)Session["SelectedCat"];

            var DT = DB.GetProductsByCategory(cat);
            var products = Product.GetListOfProducts(DT);
            var list = ProductContainer.EncapsulateProducts(products);           
            content.Add(list);         
        }

        public void Product_OnClick(object sender, EventArgs e)
        {
            var btn = (Button) sender;
            Session["SelectedProduct"] = btn.ID.ToString();


        }

        public void Test(string id)
        {
           
        }
    }
}