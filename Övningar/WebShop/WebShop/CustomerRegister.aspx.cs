
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebShop
{
    public partial class CustomerRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// On Register button click we are saving all the customer information into our database
        /// If the customer is registered successfully then we are creating sessions of customerID and CustomerName and redirecting the user to Default page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnRegister_Click(object sender, EventArgs e)
        {

            Ecom_v2Cart ecc = new Ecom_v2Cart()
            {
                CustomerName = txtName.Text,
                CustomerEmailID = txtEmailID.Text,
                CustomerAddress = txtAddress.Text,
                CustomerPhoneNo = txtPhoneNo.Text,
                CustomerPassword = txtPassword.Text
            };

            DataTable dtResult = ecc.Register();

            if (Convert.ToInt32(dtResult.Rows[0]["CustomerID"]) > 0)
            {
                Session["CustomerID"] = dtResult.Rows[0]["CustomerID"];
                Session["CustomerName"] = txtName.Text;
                Response.Redirect("Index.aspx");
            }
            else
            {

            }
        }

    }

}