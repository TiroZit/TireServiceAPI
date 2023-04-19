using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TireServiceAPI.Models.Product.Types.Tire;
using TireServiceAPI.Models.Product;

namespace TireServiceAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TireProfilesController : ControllerBase
	{
		private readonly DataContext _context;

		public TireProfilesController(DataContext context)
		{
			_context = context;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<TireProfile>>> GetTireProfiles()
		{
			if (_context.TireProfiles == null)
			{
				return NotFound();
			}
			return await _context.TireProfiles.Include(b => b.Tires).ToListAsync();
		}

		[HttpGet("{id}/tires")]
		public async Task<ActionResult<IEnumerable<Tire>>> GetTires(int id)
		{
			var TireProfile = await _context.TireProfiles.Include(b => b.Tires).FirstOrDefaultAsync(b => b.Id == id);

			if (TireProfile == null)
			{
				return NotFound();
			}

			return Ok(TireProfile.Tires);
		}

	}
}
