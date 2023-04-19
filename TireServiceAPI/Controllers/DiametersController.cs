using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TireServiceAPI.Models.Product.Types.Tire;
using TireServiceAPI.Models.Product;

namespace TireServiceAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class DiametersController : ControllerBase
	{
		private readonly DataContext _context;

		public DiametersController(DataContext context)
		{
			_context = context;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<Diameter>>> GetDiameters()
		{
			if (_context.Diameters == null)
			{
				return NotFound();
			}
			return await _context.Diameters.Include(b => b.Tires).ToListAsync();
		}

		[HttpGet("{id}/tires")]
		public async Task<ActionResult<IEnumerable<Tire>>> GetTires(int id)
		{
			var Diameter = await _context.Diameters.Include(b => b.Tires).FirstOrDefaultAsync(b => b.Id == id);

			if (Diameter == null)
			{
				return NotFound();
			}

			return Ok(Diameter.Tires);
		}

	}
}
