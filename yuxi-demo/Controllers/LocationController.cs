using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using yuxi_demo.Entity;
using yuxi_demo.Interfaces;

namespace yuxi_demo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LocationController : Controller
    {
        private IAppDBContext _context;
        public LocationController(IAppDBContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var res = await _context.Locations.ToListAsync();
            if (res == null) return NotFound();
            return Ok(res);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> Get(Guid Id) {            
            var res= await _context.Locations.Where(w => w.ID == Id).FirstOrDefaultAsync();
            if (res == null) return NotFound();
            return Ok(res);
          }

        [HttpPost]
        public async Task<Location> Post(Location location)
        {
            _context.Locations.Add(location);
            _context.SaveChangesAsync();
            return location;
        }
    }
}
