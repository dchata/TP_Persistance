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
                        name = "E. Leclerc",
                        productShops = new List<ProductShop>
                        {
                            new ProductShop
                            {
                                id = 1,
                                name = "Rhum",
                                facets = 2,
                                price = (float)14.00,
                                rack = 2
                            },

                            new ProductShop
                            {
                                id = 2,
                                name = "Chips Lays",
                                facets = 4,
                                price = (float)2.00,
                                rack = 3
                            },

                            new ProductShop
                            {
                                id = 3,
                                name = "Nuggets Père Dodu",
                                facets = 2,
                                price = (float)3.00,
                                rack = 1
                            }
                        }
                    },
                    commercial = new Commercial
                    {
                        id = 1,
                        lastName = "Truc",
                        firstName = "Dylan"
                    },
                    products = new List<ProductVisit>()
                    {
                            new ProductVisit
                            {
                                id = 1,
                                name = "Rhum"
                            },

                            new ProductVisit
                            {
                                id = 2,
                                name = "Chips Lays"
                            },

                            new ProductVisit
                            {
                                id = 3,
                                name = "Nuggets Père Dodu"
                            }
                        }
                },

                new Visit
                {
                    id = 2,
                    shop = new Shop
                    {
                        id = 2,
                        name = "Carrefour",
                        productShops = new List<ProductShop>
                        {
                            new ProductShop
                            {
                                id = 4,
                                name = "Captain Morgan",
                                facets = 2,
                                price = (float)14.00,
                                rack = 2
                            },

                            new ProductShop
                            {
                                id = 5,
                                name = "Vodka Poliakov",
                                facets = 4,
                                price = (float)15.00,
                                rack = 3
                            },

                            new ProductShop
                            {
                                id = 6,
                                name = "Glace Magnum",
                                facets = 2,
                                price = (float)5.00,
                                rack = 1
                            }
                        }
                    },
                    commercial = new Commercial
                    {
                        id = 2,
                        lastName = "Gege",
                        firstName = "JM"
                    },
                    products = new List<ProductVisit>()
                    {
                        new ProductVisit
                            {
                                id = 4,
                                name = "Captain Morgan"
                            },

                            new ProductVisit
                            {
                                id = 5,
                                name = "Vodka Poliakov"
                            },

                            new ProductVisit
                            {
                                id = 6,
                                name = "Glace Magnum"
                            }
                    }
                }
            };
        }
    }
}
