using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace övning_2._1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Label1.Text = "Jan Stenmark Generator 2.0";


        }

        public void Knappen_Click_Stenmark_It(object sender, EventArgs e)
        {
            string original = TheBox.Text;
            string Stenmark = StenmarkIt(original);

            string complete = original + " - " + Stenmark;
            TextBox2.Text = TextBox2.Text + complete +"\r";

            TheBox.Text = string.Empty;
        }
        
        public string StenmarkIt(string text)
        {
            var vokaler = new char[] { 'a', 'o', 'u', 'å', 'e', 'i', 'y', 'ä', 'ö' };
            string stenmark = text;
            foreach (char c in vokaler)
            {
                stenmark = stenmark.Replace(c, 'ö');
            }

            return stenmark;
        }

    
    }
}