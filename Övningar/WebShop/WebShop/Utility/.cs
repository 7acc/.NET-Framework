using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebShop
{
    public static class Printer
    {
        public static string ConvertByteToURl(byte[] array)
        {
            string base64String = Convert.ToBase64String(array, 0, array.Length);
            string url = "data:image/jpg;base64," + base64String;
            return url;
        }
        public static Table PrintProducts(DataTable data)
        {
            Table ProductTable = new Table();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                
                TableRow Head = new TableRow();
                TableCell HeadCell = new TableCell();
                HeadCell.Text = (string)data.Rows[i]["Name"];
                Head.Cells.Add(HeadCell);
                Head.Style.Add("text-align", "center");
                Head.Style.Add("font-size", "24px");

                TableRow imgRow = new TableRow();
                TableCell imgCell = new TableCell();

                Image pIMG = new Image();
                pIMG.Height = 150;
                pIMG.ImageUrl = ConvertByteToURl((Byte[])data.Rows[i]["ProductIMG"]);
                imgCell.Controls.Add(pIMG);

                imgRow.Cells.Add(imgCell);
                TableRow desRow = new TableRow();
                TableCell descell = new TableCell();
                desRow.Cells.Add(descell);
                descell.Text = "---TEST DESCRIPTION---";/*(string)data.Rows[i]["Description"];*/
                descell.Style.Add("font-size", "18px");
                descell.Style.Add("text-align", "center");
                TableRow btnRow = new TableRow();
                TableCell btncell = new TableCell();

                Button btn = new Button();

                btncell.Style.Add("text-align", "center");
                btn.Text = "Details";
                btncell.Controls.Add(btn);

                btnRow.Cells.Add(btncell);


                ProductTable.Rows.Add(Head);
                ProductTable.Rows.Add(imgRow);
                ProductTable.Rows.Add(desRow);
                ProductTable.Rows.Add(btnRow);
                ProductTable.Width = 130;
                ProductTable.Style.Add("margin-left","30px");
                ProductTable.Style.Add("margin-right", "30px");
                ProductTable.Style.Add("margin-top", "30px");
                ProductTable.Style.Add(" background-color", "white");
                ProductTable.BorderStyle = BorderStyle.Solid;
                ProductTable.BorderWidth = 1;
                ProductTable.BorderColor = System.Drawing.Color.LightGray;
             


            }
            return ProductTable;
        }

    }
}