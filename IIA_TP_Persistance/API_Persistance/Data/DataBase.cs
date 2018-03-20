using API_Persistance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Persistance.Data
{
    public class DataBase
    {
        public IList<Visit> Visits { get; set; }

        public DataBase()
        {
            Visits = GetVisits();
        }

        public IList<Visit> GetVisits()
        {
            return new List<Visit>
            {
                new Visit
                {
                    id = 1,
                    shop = new Shop
                    {
                        id = 1,
                        name = "E. Leclerc"
                    },
                    commercial = new Commercial
                    {
                        id = 1,
                        lastName = "Truc",
                        firstName = "Dylan"
                    },
                    products = new List<ProductVisit>
                    {
                        new ProductVisit
                        {
                            id = 1,
                            name = "Chips Lays",
                            price = (float)12.00,
                            facets = 2,
                            rack = 1,
                            missing = true
                        },
                        new ProductVisit
                        {
                            id = 2,
                            name = "Chips Vico",
                            price = (float)15.00,
                            facets = 3,
                            rack = 2,
                            missing = false
                        },
                        new ProductVisit
                        {
                            id = 3,
                            name = "Rhum",
                            price = (float)5.00,
                            facets = 1,
                            rack = 1,
                            missing = true
                        }
                    }
                },
                new Visit
                {
                    id = 2,
                    shop = new Shop
                    {
                        id = 2,
                        name = "Carrefour"
                    },
                    commercial = new Commercial
                    {
                        id = 2,
                        lastName = "Gege",
                        firstName = "JM"
                    },
                    products = new List<ProductVisit>
                    {
                        new ProductVisit
                        {
                            id = 4,
                            name = "Steak",
                            price = (float)12.90,
                            facets = 2,
                            rack = 1,
                            missing = true
                        },
                        new ProductVisit
                        {
                            id = 5,
                            name = "Chips Lays",
                            price = (float)15.50,
                            facets = 3,
                            rack = 2,
                            missing = false
                        },
                        new ProductVisit
                        {
                            id = 6,
                            name = "Tomates",
                            price = (float)5.75,
                            facets = 1,
                            rack = 1,
                            missing = true
                        }
                    }
                }
            };
        }
    }
}
