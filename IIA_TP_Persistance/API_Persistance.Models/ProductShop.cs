using API_Persistance.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace API_Persistance.Models
{
    public class ProductShop
    {
        private int Id;
        private string Name;
        private float Price;
        private int Facets;
        private int Rack;
        private Shop Shop;

        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
        public int rack
        {
            get { return Rack; }
            set { Rack = value; }
        }

        public int facets
        {
            get { return Facets; }
            set { Facets = value; }
        }

        public float price
        {
            get { return Price; }
            set { Price = value; }
        }

        public int id
        {
            get { return Id; }
            set { Id = value; }
        }
        public Shop shop
        {
            get { return Shop; }
            set { Shop = value; }
        }
    }
}
