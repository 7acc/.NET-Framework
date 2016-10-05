using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebShop
{
    public partial class Kassan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {//Visa ordern
            
            mydiv.InnerHtml = BuildTable((Cart)Session["Cart"]);            
        }
        public string BuildTable(Cart cart)
        {
            string tblcontent = "<table class=\"table table - striped\" runat =\"server\"><tr><td> Nr </td><td> Namn </td><td> Färg </td><td> Storlek </td><td> Antal </td><td> Pris </td><td> Totalt </td></tr>";
            decimal totalt = 0;
            for (int i = 0; i < cart.cart.Count; i++)
            {

                totalt += cart.cart[i].Price * cart.cart[i].Quantity;
                tblcontent += "<tr><td> " + i + " </td><td> " + cart.cart[i].Name + " </td><td> " + cart.cart[i].Color + " </td><td> " + cart.cart[i].Size + " </td><td> " + cart.cart[i].Quantity + " </td><td> " + string.Format("{0:0.00}", cart.cart[i].Price) + " </td><td> " + string.Format("{0:0.00}", cart.cart[i].Quantity * cart.cart[i].Price) + " </td></tr>";


            }

            mydiv2.InnerHtml = "<p>        Köpesumma : " + string.Format("{0:0.00}", totalt) + " </p>";
            tblcontent += "</table>";
            return tblcontent;
        }

        protected void btnCheckOut_Click(object sender, EventArgs e)
        {
            //spara ner i databasen




        }
    }
}