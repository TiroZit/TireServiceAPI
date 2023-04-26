using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TireServiceAPI.Models.Favourite;

namespace TireServiceAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class FavouriteController : ControllerBase
	{
		private readonly DataContext _context;

		public FavouriteController(DataContext context)
		{
			_context = context;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<Favourite>>> GetFavourites()
		{
			if (_context.Carts == null)
			{
				return NotFound();
			}
			return await _context.Favourites
				.Include(c => c.FavouriteItems)
					.ThenInclude(c => c.Tire)
				.Include(c => c.FavouriteItems)
					.ThenInclude(c => c.Wheel)
				.ToListAsync();
		}

		[HttpGet("{id}/favourite")]
		public async Task<ActionResult<IEnumerable<Favourite>>> GetFavouriteItems(int id)
		{
			var cartitems = await _context.Favourites
				.Include(c => c.FavouriteItems)
					.ThenInclude(c => c.Tire)
				.Include(c => c.FavouriteItems)
					.ThenInclude(c => c.Wheel)
				.ToListAsync();

			var cart = await _context.Favourites
				.FirstOrDefaultAsync(b => b.Id == id);

			if (cart == null)
			{
				return NotFound();
			}

			return Ok(cart.FavouriteItems);
		}
	}
}
