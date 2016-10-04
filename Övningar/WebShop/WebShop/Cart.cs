


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
    public class Cart
    {
        public List<CartItem> cart { get; set; }
        public HtmlGenericControl CartDiv { get; set; }


        public Cart()
        {
            cart = new List<CartItem>();
        }

        public void BuildCart()
        {
            CartDiv = new HtmlGenericControl();
            CartDiv.ID = "CartContainer";
            foreach (CartItem item in cart)
            {
                CartDiv.Controls.Add(Addrow(item));
            }
        }
        public HtmlGenericControl Addrow(CartItem item)
        {
            HtmlGenericControl itemContainer = new HtmlGenericControl("div");
            itemContainer.Attributes.Add("class", "Rowcontainer");
            itemContainer.Attributes.Add("ID", item.ArticleID.ToString() + item.Size);
            

            Image thumb = new Image
            {
                ImageUrl = item.ThumbNail,
                CssClass = "CartThumb"
            };

            Label name = new Label
            {
                Text = item.Name,
                CssClass = "Name"
            };
            Label price = new Label
            {
                Text = item.Price.ToString(),
                CssClass = "rowPrice"
            };
            DropDownList Quantity = new DropDownList {
                CssClass ="ddl"
            };
            for (int i = 1; i <= item.inStore; i++)
            {
                Quantity.Items.Add(i.ToString());
            }
            Quantity.Items.FindByValue(item.Quantity.ToString()).Selected = true;
            Quantity.SelectedIndexChanged += new System.EventHandler(Quantity_IndexChanged);
            Quantity.ID = "D" + item.Size + item.ArticleID.ToString();
            Quantity.AutoPostBack = true;
            Quantity.Width = 40;

            Label Details = new Label
            {
                Text = item.Color + " -  size: " + item.Size,
                CssClass = "CartDetails"
            };

            Button removebutton = new Button
            {
                Text = "X",
                ID = item.Size + item.ArticleID.ToString(),
                CssClass = "RemoveButton"
                
                
            };
            removebutton.Click += new System.EventHandler(Remove_ItemOnClick);

            itemContainer.Controls.Add(thumb);
            itemContainer.Controls.Add(name);
            itemContainer.Controls.Add(price);
            itemContainer.Controls.Add(Quantity);
            itemContainer.Controls.Add(Details);          
            itemContainer.Controls.Add(removebutton);

            return itemContainer;
        }
        public HtmlGenericControl GetCart()
        {
            
            BuildCart();            

            return CartDiv;
        }
        public void Remove_ItemOnClick(object sender, EventArgs e)
        {
            
            Button btn = (Button)sender;          
            cart.Remove(cart.Where(x => x.ArticleID.ToString() == btn.ID.Substring(1)).FirstOrDefault());
            
        }
        public void AddItem(Article article, string size, int quantity)
        {

            if (cart.Any(x => x.ArticleID == article.ArticleID && x.Size == size))
            {
                CartItem item = cart.Find(x => x.ArticleID == article.ArticleID);
                item.Quantity++;
            }
            else
            {
                cart.Add(new CartItem(article, size));
            }
        }

        public int GetTotalPrice()
        {
            decimal totalPrice = 0;
            foreach (CartItem item in cart)
            {
                totalPrice += item.Price * item.Quantity;
            }
            return Convert.ToInt32(totalPrice);
        }
        public void Quantity_IndexChanged(object sender, EventArgs e)
        {
            DropDownList ddl = (DropDownList)sender;
            CartItem item = cart.Find(x => x.ArticleID.ToString() == ddl.ID.Substring(2));
            item.Quantity = int.Parse(ddl.SelectedValue);
            
        }


        


    }
}