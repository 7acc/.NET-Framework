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
    public class ProductContainer : Categories
    {
        public Image Image { get; set; }
        public Label TitleLabel { get; set; }
        public Label Description { get; set; }
        public Button IdButton { get; set; }

        public ProductContainer(string image, string title, string description, string id)
        {
            this.Image = new Image
            {
                ImageUrl = image,
                CssClass = "cIMG"           
            };
            this.TitleLabel = new Label
            {
                Text = title,
                CssClass = "cTitle"
            };
            this.Description = new Label
            {
                Text = description,
                CssClass = "cDesc"
            };
            this.IdButton = new Button
            {
                ID = id,
                CssClass = "cBtn",                
            };
            this.IdButton.Click += new System.EventHandler(Product_OnClick);
        }

      

        public static List<HtmlGenericControl> EncapsulateProducts(List<Product> products)
        {
            List<HtmlGenericControl> list = new List<HtmlGenericControl>();
            foreach (var product in products)
            {
                var controls = new ProductContainer(
                    product.ProductIMG,
                    product.Name,
                    product.Description,
                   "cat" + product.ID.ToString()
                   );

                var container = Encapsulate(controls);
                list.Add(container);
            }
            return (list);
        }
        private static HtmlGenericControl Encapsulate(ProductContainer temp)
        {
            HtmlGenericControl container = new HtmlGenericControl();
            container.Attributes.Add("class", "cContainer");
            container.ID = temp.TitleLabel.Text;
            container.Controls.Add(temp.TitleLabel);
            container.Controls.Add(temp.Image);
            container.Controls.Add(temp.Description);
            container.Controls.Add(temp.IdButton);

            return container;
        }


    }
}