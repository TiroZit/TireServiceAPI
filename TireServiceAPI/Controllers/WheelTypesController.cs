using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TireServiceAPI.Models.Product.Types.Tire;
using TireServiceAPI.Models.Product;
using TireServiceAPI.Models.Product.Types.Wheel;

namespace TireServiceAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class WheelTypesController : ControllerBase
	{
		private readonly DataContext _context;

		public WheelTypesController(DataContext context)
		{
			_context = context;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<WheelType>>> GetWheelTypes()
		{
			if (_context.WheelTypes == null)
			{
				return NotFound();
			}
			return await _context.WheelTypes.Include(b => b.Wheels).ToListAsync();
		}

		[HttpGet("{id}/wheels")]
		public async Task<ActionResult<IEnumerable<Tire>>> GetTires(int id)
		{
			var WheelType = await _context.WheelTypes.Include(b => b.Wheels).FirstOrDefaultAsync(b => b.Id == id);

			if (WheelType == null)
			{
				return NotFound();
			}

			return Ok(WheelType.Wheels);
		}
	}
}
