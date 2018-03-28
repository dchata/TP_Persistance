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
        private bool Saved;
        private Visit Visit;
        #endregion

        #region Access
        public bool missing
        {
            get { return Missing; }
            set { Missing = value; }
        }

        public bool saved { get => Saved; set => Saved = value; }
        public Visit visit { get => Visit; set => Visit = value; }
        #endregion

        #region Constructors
        public ProductVisit()
        {

        }
        public ProductVisit(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        #endregion
    }
}
