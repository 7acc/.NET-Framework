using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebShop
{
    public partial class Categories : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DAL_article DB = new DAL_article();
            string cat = (string)Session["SelectedCat"];
            var DT = DB.GetArticleById(cat);
            var products = Article.GetListOfArticles(DT);
            Session["currentCat"] = products;

            var list = ProductContainer.EncapsulateProducts(products);
            content.Add(list);
        }   

        public void Product_OnClick(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            var article = (List<Article>)Session["CurrentCat"];
            Session["SelectedProduct"] = article.Find(x => x.ArticleID.ToString() == btn.ID.ToString().Substring(3));
            Server.Transfer("ProductDetails.aspx", true);


        }

    }
}