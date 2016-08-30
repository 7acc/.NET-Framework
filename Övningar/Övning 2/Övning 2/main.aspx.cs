using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Övning_2
{
    public partial class main : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            TheBox.Text = "Im the BOX";
           

        }

        void Knappen_Click_Stenmark_It(Object sender, EventArgs e)
        {
            string original = TheBox.Text;
            string Stenmark = StenmarkIt(original);

            string complete = original + " - " + Stenmark + "/n";
            textbox2.Text = textbox2.Text + complete;
        }





        public string StenmarkIt(string boxtext)
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