using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Föreläsning_1_asp_web_forms
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Result_Content.Style.Add("padding", "10px");


        }
        public void Knappen_Click_Stenmark(Object sender, EventArgs e)
        {
            Result_Content.Visible = true;          
           Result_Content.Text = Stenmark(Boxen.Text);
            Boxen.Text = "";
           







        }

        public string Stenmark(string boxtext)
        {
            var vokaler = new char[] { 'a', 'o', 'u', 'å', 'e', 'i', 'y', 'ä', 'ö' };
            string test = boxtext;
            foreach (char c in vokaler)
            {
                test = test.Replace(c, 'ö');
            }

            return test;
        }


    }
}