using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebShop.Utility
{
    public class ShoppingCartHandler
    {

        private List<CartItem> Cart;

      

        public void CartToSession(DataTable DT)
        {
            List<CartItem> cart = new List<CartItem>();
            foreach (DataRow row in DT.Rows)
            {
               
            }
        }

    

    }
}