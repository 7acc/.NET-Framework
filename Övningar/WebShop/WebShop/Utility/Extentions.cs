using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace WebShop
{
    public static class Extentions
    {

        public static void Add(this HtmlGenericControl container, List<HtmlGenericControl> list)
        {
            foreach (var item in list)
            {
                container.Controls.Add(item);
            }
        }
       

        public static string ConvertToURL(this byte[] array)
        {
            string base64String = Convert.ToBase64String(array, 0, array.Length);
            string url = "data:image/jpg;base64," + base64String;
            return url;
        }
    }
}