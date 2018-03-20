using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Persistance.Data;
using API_Persistance.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_Persistance.Controllers
{
    [Produces("application/json")]
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
            return Ok(_visitService.GetVisits().Where(v => v.commercial.lastName.ToLower() == commercial.ToLower()));
        }

        [HttpPost]
        [Route("setVisit")]
        [Produces(typeof(string))]
        public IActionResult SetVisits(string commercial, [FromBody]string content)
        {
            var result = _visitService.SetVisit();

            if (result != null)
                return Ok();

            return BadRequest();
        }
    }
}
