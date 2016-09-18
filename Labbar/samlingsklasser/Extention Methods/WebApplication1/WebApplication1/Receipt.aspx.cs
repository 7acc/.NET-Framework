using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;

namespace WebApplication1
{
    public partial class Receipt : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

           
               

        }
        

        public void LoadBasket(object sender, EventArgs e)
        { 


            string JSON = HF.Value;
            var jss = new JavaScriptSerializer();

            Dictionary<string, string> values = jss.Deserialize<Dictionary<string, string>>(JSON);
            List<TableRow> TR = new List<TableRow>();

            foreach (var product in values)
            {
                TableRow row = new TableRow();
                TableCell cell = new TableCell();
                TableCell cell2 = new TableCell();

                cell.Text = product.Key;
                cell2.Text = product.Value;
               
                row.Cells.Add(cell);
                row.Cells.Add(cell2);

                products.Rows.Add(row);        
            }
             
            
        }

       
    }
}