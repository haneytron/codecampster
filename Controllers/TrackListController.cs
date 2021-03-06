using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Mvc;
using Microsoft.Data.Entity;
using codecampster.Models;

namespace codecampster.Controllers
{
    [Produces("application/json")]
    [Route("api/TrackList")]
    public class TrackListController : Controller
    {
        private ApplicationDbContext _context;

        public TrackListController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/TrackList
        [HttpGet]
        [ResponseCache(Duration = 3600, Location = ResponseCacheLocation.Any)]
        public IEnumerable<Track> GetTracks()
        {
            return _context.Tracks;
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