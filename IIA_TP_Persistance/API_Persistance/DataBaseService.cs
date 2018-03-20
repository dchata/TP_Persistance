using API_Persistance.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Persistance
{
    public class DataBaseService
    {
        public static DataBase DataBase { get; set; }

        static DataBaseService()
        {
            if (DataBase == null)
                DataBase = new DataBase();
        }
    }
}
