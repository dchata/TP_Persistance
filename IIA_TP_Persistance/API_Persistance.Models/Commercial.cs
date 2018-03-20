using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Persistance.Model
{
    public class Commercial
    {
        #region Properties
        private int Id;
        private string LastName;
        private string FirstName;
        #endregion

        #region Access
        public string firstName
        {
            get { return FirstName; }
            set { FirstName = value; }
        }

        public string lastName
        {
            get { return LastName; }
            set { LastName = value; }
        }

        public int id
        {
            get { return Id; }
            set { Id = value; }
        }
        #endregion

        #region Constructors
        public Commercial()
        {
        }

        public Commercial(int id, string lname, string fname)
        {
            Id = id;
            LastName = lname;
            FirstName = fname;
        }
        #endregion
    }
}
