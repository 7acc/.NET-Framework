﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PasswordHash hash = new PasswordHash();

            string salt = hash.CreateSalt();
            string hashedPass = hash.GeneratePaswordHash("Utter", salt);
        }        






























        3
















        3














        ,,

        ,
        ,,
        ,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,










































































































































































































































































































        protected void Button2_Click(object sender, EventArgs e)
        {

            var button = (Button)sender;
            var id = button.ID;
            Session["User"] = T1.Text;
            
            Response.Redirect("Restore.aspx");
        }
    }
}