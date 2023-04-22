using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TireServiceAPI.Models.Cart;

namespace TireServiceAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CartsController : ControllerBase
	{
		private readonly DataContext _context;

		public CartsController(DataContext context)
		{
			_context = context;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<Cart>>> GetCarts()
		{
			if (_context.Carts == null)
			{
				return NotFound();
			}
			return await _context.Carts
				.Include(c => c.CartItems)
					.ThenInclude(c => c.Tire)
				.Include(c => c.CartItems)
					.ThenInclude(c => c.Wheel)
				.ToListAsync();
		}

		[HttpGet("{id}/carts")]
		public async Task<ActionResult<IEnumerable<Cart>>> GetCartItems(int id)
		{
			var cartitems = await _context.Carts
				.Include(c => c.CartItems)
					.ThenInclude(c => c.Tire)
				.Include(c => c.CartItems)
					.ThenInclude(c => c.Wheel)
				.ToListAsync();

			var cart = await _context.Carts
				.FirstOrDefaultAsync(b => b.Id == id);

			if (cart == null)
			{
				return NotFound();
			}

			return Ok(cart.CartItems);
		}
	}
}
