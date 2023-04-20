using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TireServiceAPI.Models.Product.Types.Tire;
using TireServiceAPI.Models.Product;

namespace TireServiceAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TireSeasonsController : ControllerBase
	{
		private readonly DataContext _context;

		public TireSeasonsController(DataContext context)
		{
			_context = context;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<TireSeason>>> GetTireSeasons()
		{
			if (_context.TireSeasons == null)
			{
				return NotFound();
			}
			return await _context.TireSeasons.Include(b => b.Tires).ToListAsync();
		}

		[HttpGet("{id}/tires")]
		public async Task<ActionResult<IEnumerable<Tire>>> GetTires(int id)
		{
			var TireSeason = await _context.TireSeasons.Include(b => b.Tires).FirstOrDefaultAsync(b => b.Id == id);

			if (TireSeason == null)
			{
				return NotFound();
			}

			return Ok(TireSeason.Tires);
		}
	}
}
