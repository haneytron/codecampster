using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Mvc;
using Microsoft.Data.Entity;
using codecampster.Models;

namespace codecampster.Controllers
{
    [Produces("application/json")]
    [Route("api/TimeslotList")]
    public class TimeslotListController : Controller
    {
        private ApplicationDbContext _context;

        public TimeslotListController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/TimeslotList
        [HttpGet]
        [ResponseCache(Duration = 3600, Location = ResponseCacheLocation.Any)]
        public IEnumerable<Timeslot> GetTimeslots()
        {
            return _context.Timeslots.OrderBy(t => t.Rank);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}