using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExeptionTest
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit(object sender, EventArgs e)
        {

            foreach (TableRow row in myTable.Rows)
            {
                foreach (TableCell cell in row.Cells)
                {
                    foreach (var box in cell.Controls)
                    {

                        if (box is TextBox)
                        {
                            TextBox textBox = (TextBox)box;
                            Result.Text += textBox.Text + " ";
                        }
                    }
                }
            }
        }
    }
}