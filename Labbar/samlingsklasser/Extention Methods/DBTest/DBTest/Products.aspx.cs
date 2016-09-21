using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace DBTest
{
    public partial class Products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBconnect DB = new DBconnect();

            DataTable data  = DB.GetProductsByCategory();

            //foreach (var item in data.Rows)
            //{
            //    Image img = new Image();
            //    img.ImageUrl = item.ToString();
            //    Page.Controls.Add(img);
            //}
            for (int i = 0; i < data.Rows.Count; i++)
            {
                Image img = new Image();
                Label lbl = new Label();
                img.Attributes["runat"] = "server";
                byte[] bytes = (byte[])data.Rows[i]["ProductIMG"];
                string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);

                img.ImageUrl = "data:image/jpg;base64," + base64String;


                lbl.Text = data.Rows[i]["Name"].ToString();

                img.Height = 100;            
                Page.Controls.Add(img);
                Page.Controls.Add(lbl);

            }

        }
    }
}