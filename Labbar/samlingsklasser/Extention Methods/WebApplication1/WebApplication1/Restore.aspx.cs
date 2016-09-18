using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Restore : System.Web.UI.Page
    {
        private static bool Restored = false;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if(!Restored)
            {
                Button2.Text = "Next";
                Restored = true;
            }
            else
            {
                Response.Redirect("LocalList.aspx");
            }
        }
    }
}