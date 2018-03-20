using API_Persistance.Data;
using API_Persistance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Persistance
{
    public class VisitService
    {
        public virtual IEnumerable<Visit> GetVisits()
        {
            var result = DataBaseService.DataBase.Visits;

            return result;
        }

        public virtual Visit SetVisit()
        {
            var result = new Visit();

            

            return result;
        }
    }
}
