using System;
using System.Collections.Generic;
using System.Text;

namespace API_Persistance.Models
{
    public class Shop
    {
        private int Id;
        private string Name;
        private List<ProductShop> ProductsShop;

        public string name
        {
            get { return Name; }
            set { Name = value; }
        }

        public int id
        {
            get { return Id; }
            set { Id = value; }
        }

        public List<ProductShop> productShops { get => ProductsShop; set => ProductsShop = value; }
    }
}
