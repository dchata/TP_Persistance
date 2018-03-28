using API_Persistance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Persistance.Models
{
    public class ProductVisit
    {
        #region Properties
        private int Id;
        private string Name;
        private float Price;
        private int Facets;
        private int Rack;
        private bool Missing;
        private bool Saved;
        private Visit Visit;
        #endregion

        #region Access
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
