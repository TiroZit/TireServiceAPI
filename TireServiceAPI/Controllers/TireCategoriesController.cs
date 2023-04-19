using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TireServiceAPI.Models.Product.Types.Tire;

namespace TireServiceAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TireCategoriesController : ControllerBase
	{
		private readonly DataContext _context;

		public TireCategoriesController(DataContext context)
		{
			_context = context;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<TireCategory>>> GetTireCategories()
		{
			if (_context.TireCategories == null)
			{
				return NotFound();
			}
			return await _context.TireCategories.Include(b => b.Tires).ToListAsync();
		}

		[HttpGet("{id}/tires")]
		public async Task<ActionResult<IEnumerable<Tire>>> GetTires(int id)
		{
			var TireCategory = await _context.TireCategories.Include(b => b.Tires).FirstOrDefaultAsync(b => b.Id == id);

			if (TireCategory == null)
			{
				return NotFound();
			}

			return Ok(TireCategory.Tires);
		}
	}
}
