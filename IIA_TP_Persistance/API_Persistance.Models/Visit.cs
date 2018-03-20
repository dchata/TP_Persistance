using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Persistance.Models
{
    public class Visit
    {
        #region Properties
        private int Id;
        private DateTime? Date;
        private List<ProductVisit> Products;
        private bool Finished;
        private Shop Shop;
        private Commercial Commercial;
        #endregion

        #region Access
        public Commercial commercial
        {
            get { return Commercial; }
            set { Commercial = value; }
        }
        public Shop shop
        {
            get { return Shop; }
            set { Shop = value; }
        }
        public bool finished
        {
            get { return Finished; }
            set { Finished = value; }
        }
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
        public Visit()
        {

        }
        #endregion
    }
}
