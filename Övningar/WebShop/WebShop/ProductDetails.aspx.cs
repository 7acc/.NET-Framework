using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebShop
{
    public partial class ProductDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Article> list = Session["currentCat"] as List<Article>;
            List<Article> articles = new List<Article>();

            Article selected = Session["SelectedProduct"] as Article;

            foreach (var item in list)
            {
                if(item.ProductID == selected.ProductID)
                {
                    articles.Add(item);
                }
            }

            ShowArticle(selected);
        }

        public void ShowArticle(Article article)
        {
            ProductImage.ImageUrl = article.BigPicture;
            description.InnerText = article.Description;
            ProductName.InnerText = article.Color + " " + article.Name + " " + article.Brand;
        }
    }
}