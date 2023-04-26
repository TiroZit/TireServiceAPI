using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TireServiceAPI.Models.Cart;
using TireServiceAPI.Models.Favourite;

namespace TireServiceAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class FavouriteItemController : ControllerBase
	{
		private readonly DataContext _context;

		public FavouriteItemController(DataContext context)
		{
			_context = context;
		}

		// GET: api/CartItems
		[HttpGet]
		public async Task<ActionResult<List<FavouriteItem>>> Get()
		{
			if (_context.CartItems == null)
			{
				return NotFound();
			}
			return await _context.FavouriteItems.Include(c => c.Tire).Include(c => c.Wheel).ToListAsync();
		}

		// GET: api/CartItems/5
		[HttpGet("{id}")]
		public async Task<ActionResult<CartItem>> GetFavouriteItem(int id)
		{
			var FavouriteItem = await _context.CartItems.Include(c => c.Tire).Include(c => c.Wheel).FirstOrDefaultAsync(t => t.Id == id);

			if (FavouriteItem == null)
			{
				return NotFound();
			}

			return FavouriteItem;
		}

		// PUT: api/CartItems/5
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPut("{id}")]
		public async Task<IActionResult> PutTire(int id, FavouriteItem FavouriteItem)
		{
			if (id != FavouriteItem.Id)
			{
				return BadRequest();
			}

			_context.Entry(FavouriteItem).State = EntityState.Modified;

			try
			{
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!TireExists(id))
				{
					return NotFound();
				}
				else
				{
					throw;
				}
			}

			return NoContent();
		}

		// POST: api/CartItems
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPost]
		public async Task<ActionResult<CartItem>> PostTire(FavouriteItem FavouriteItem)
		{
			var existingItem = await _context.FavouriteItems.FirstOrDefaultAsync(ci => ci.TireId == FavouriteItem.TireId);
			if (existingItem != null)
			{
				return Conflict(); // Возвращаем ошибку 409 Conflict, если элемент уже существует
			} 
			else
			{
				_context.FavouriteItems.Add(FavouriteItem);
				await _context.SaveChangesAsync();
				return CreatedAtAction(nameof(GetFavouriteItem), new { id = FavouriteItem.Id }, FavouriteItem);
			}
		}

		// DELETE: api/CartItems/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteTire(int id)
		{
			var FavouriteItem = await _context.FavouriteItems.FindAsync(id);
			if (FavouriteItem == null)
			{
				return NotFound();
			}

			_context.FavouriteItems.Remove(FavouriteItem);
			await _context.SaveChangesAsync();

			return NoContent();
		}

		private bool TireExists(int id)
		{
			return _context.FavouriteItems.Any(t => t.Id == id);
		}
	}
}
