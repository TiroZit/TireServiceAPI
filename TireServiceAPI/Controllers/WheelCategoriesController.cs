using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TireServiceAPI.Models.Product.Types.Wheel;

namespace TireServiceAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class WheelCategoriesController : ControllerBase
	{
		private readonly DataContext _context;

		public WheelCategoriesController(DataContext context)
		{
			_context = context;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<WheelCategory>>> GetWheelCategories()
		{
			if (_context.WheelCategories == null)
			{
				return NotFound();
			}
			return await _context.WheelCategories.Include(b => b.Wheels).ToListAsync();
		}

		[HttpGet("{id}/wheels")]
		public async Task<ActionResult<IEnumerable<Wheel>>> GetWheels(int id)
		{
			var WheelCategory = await _context.WheelCategories.Include(b => b.Wheels).FirstOrDefaultAsync(b => b.Id == id);

			if (WheelCategory == null)
			{
				return NotFound();
			}

			return Ok(WheelCategory.Wheels);
		}
	}
}
