using API_Persistance.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace API_Persistance.Models
{
    public class ProductShop : Product
    {
        private Shop Shop;

        public Shop shop
        {
            get { return Shop; }
            set { Shop = value; }
        }
    }
}
