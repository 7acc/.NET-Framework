using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace övning_2._1
{
    public partial class CurrencyConverter : System.Web.UI.Page
    {

     
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void Convert_button_Click(object sender, EventArgs e)
        {
            double dollars = double.Parse(DropDownList_From.SelectedValue) * double.Parse(Amount_TextBox.Text);
            double converted = double.Parse(DropDownList_To.SelectedValue) * dollars;

            Converted_textbox.Text = converted.ToString();






        

        }


    }
}