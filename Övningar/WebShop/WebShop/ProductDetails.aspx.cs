using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using WebShop.Utility;

namespace WebShop
{
    public partial class ProductDetails : System.Web.UI.Page
    {
        public List<Article> list;
        public Article selected;
        public static List<Article> articles;
        protected void Page_Load(object sender, EventArgs e)
        {

            list = Session["currentCat"] as List<Article>;

            selected = Session["SelectedProduct"] as Article;
           
                articles = list.Where(item => item.ProductID == selected.ProductID).ToList();
            

            BuildColorPickers(colors, articles, selected);
            if (!Page.IsPostBack)
            {
            
                ShowArticle(selected);
            }
        }

        public void BindDdlToSizes(Article selected)
        {
            SizeDDL.DataSource = selected.Sizes;
        
            SizeDDL.DataValueField = "value";
            SizeDDL.DataTextField = "key";
            SizeDDL.DataBind();
            SetInStoreLabelText(Convert.ToInt32(SizeDDL.SelectedValue));
        }
        public void ShowArticle(Article article)
        {
            ProductImage.ImageUrl = article.BigPicture;
            description.InnerText = article.Description;
            ProductName.InnerText = article.Color + " " + article.Name + " " + article.Brand + " --- " + $"{article.Price:C}";

            BindDdlToSizes(article);
        }

        public void SetInStoreLabelText(int value)
        {
            if (value > 5)
            {
                inStoreLabel.ForeColor = Color.Green;
                inStoreLabel.Text = "in store: " + value;
            }
            else if (value != 0 && value< 5)
            {
                inStoreLabel.ForeColor = Color.DarkOrange;
                inStoreLabel.Text = "in store: " + value;
            }
            else
            {
                inStoreLabel.ForeColor = Color.Red;
                inStoreLabel.Text = "Out of Stock";
            }
        }
        public void SizeDDL_SelectedIndexChanged(Object sender, EventArgs e)
        {
           DropDownList ddl = (DropDownList)sender;
               SetInStoreLabelText(Convert.ToInt32(ddl.SelectedValue));
                
            

        }
        public void BuildColorPickers(HtmlGenericControl container, List<Article> list, Article selected)
        {
            foreach (var item in list)
            {
                RadioButton rb = new RadioButton();
                Label lbl = new Label();

                if (item.ArticleID == selected.ArticleID)
                {
                    rb.Checked = true;
                }


                rb.ID = item.ArticleID.ToString();
                rb.BorderColor = System.Drawing.Color.FromName(item.Color);
                lbl.AssociatedControlID = item.ArticleID.ToString();
                lbl.Text = item.Color;
                rb.GroupName = "radios";
                rb.AutoPostBack = true;
                rb.Attributes.Add("runat", "server");
                lbl.Attributes.Add("runat", "server");
                rb.CheckedChanged += new System.EventHandler(Radio_OnCheckChanged);
                container.Controls.Add(rb);
                container.Controls.Add(lbl);
            }



        }

        public void Radio_OnCheckChanged(Object sender, EventArgs e)
        {

            RadioButton btn = (RadioButton)sender;
            Article newArticle = articles.Find(x => x.ArticleID.ToString() == btn.ID);
            Session["SelectedProduct"] = newArticle;
            ShowArticle(newArticle);


        }


        protected void AddToBasket_OnClick(object sender, EventArgs e)
        {
            if (Session["Cart"] == null)
            {
                Cart newCart = new Cart();
                newCart.AddItem(selected, SizeDDL.SelectedItem.Text, 1);
                Session["Cart"] = newCart;

            }
            else
            {
                Cart cart = (Cart)Session["Cart"];
                cart.AddItem(selected, SizeDDL.SelectedItem.Text, 1);
                Session["Cart"] = cart;

            }
        }

        protected void Button1_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("ShoppingCart.aspx");
        }
    }
}