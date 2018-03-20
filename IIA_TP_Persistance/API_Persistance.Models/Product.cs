using System;
using System.Collections.Generic;
using System.Text;

namespace API_Persistance.Models
{
    public abstract class Product
    {
        #region Properties
        private int Id;
        private float Price;
        private int Facets;
        private int Rack;
        #endregion

        #region Access
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
        #endregion
    }
}
