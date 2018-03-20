using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Persistance.Model
{
    public class Visit
    {
        #region Properties
        private int Id;
        private DateTime? Date;
        private List<ProductVisit> Products;
        #endregion

        #region Access
        public List<ProductVisit> products
        {
            get { return Products; }
            set { Products = value; }
        }
        public DateTime? date
        {
            get { return Date; }
            set { Date = value; }
        }

        public int id
        {
            get { return Id; }
            set { Id = value; }
        }
        #endregion

        #region Constructors
        public Visit(int id, DateTime? date, List<ProductVisit> products)
        {
            Id = id;
            Date = date;
            Products = products;
        }
        #endregion
    }
}
