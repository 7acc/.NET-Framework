using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_OnClick(object sender, EventArgs e)
        {


                foreach (var item in Request.Form)
                {
                    Submitted.Text += item;
                }
            
            
        }
    }
}