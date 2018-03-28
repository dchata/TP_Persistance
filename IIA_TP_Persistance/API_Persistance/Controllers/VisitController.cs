using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Persistance.Data;
using API_Persistance.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_Persistance.Controllers
{
    [Route("api/visit")]
    public class VisitController : Controller
    {
        private readonly VisitService _visitService;

        public VisitController()
        {
            _visitService = new VisitService();
        }

        [HttpGet]
        [Produces(typeof(IEnumerable<Visit>))]
        public IActionResult GetVisits(string commercial)
        {
            return Ok(_visitService.GetVisits().Where(v => v?.commercial?.lastName.ToLower() == commercial?.ToLower()));
        }

        [HttpPost]
        [Route("setVisit")]
        [Produces(typeof(string))]
        public IActionResult SetVisits(string commercial, int visitId, string data)
        {
            bool result = false;

            if (data != null)
            {
                Visit visit = _visitService.GetVisits().Where(v => v?.commercial?.lastName.ToLower() == commercial?.ToLower()).FirstOrDefault();
                result = _visitService.SetVisit(commercial, data, visit);
            }

            if (result)
                return Ok();
            else
                return BadRequest();
        }
    }
}
