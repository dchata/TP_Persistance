using API_Persistance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Persistance.Models
{
    public class ProductVisit : Product
    {
        #region Properties
        private bool Missing;
        #endregion

        #region Access
        public bool missing
        {
            get { return Missing; }
            set { Missing = value; }
        }
        #endregion

        #region Constructors
        public ProductVisit(int id, float price, int facets, int rack, bool missing)
        {
            this.id = id;
            this.price = price;
            this.facets = facets;
            this.rack = rack;
            Missing = missing;
        }
        #endregion
    }
}
