using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TireServiceAPI.Models.Cart;

namespace TireServiceAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CartItemsController : ControllerBase
	{
		private readonly DataContext _context;

		public CartItemsController(DataContext context)
		{
			_context = context;
		}

		// GET: api/CartItems
		[HttpGet]
		public async Task<ActionResult<IEnumerable<CartItem>>> GetCartItems()
		{
			if (_context.CartItems == null)
			{
				return NotFound();
			}
			return await _context.CartItems.ToListAsync();
		}

		// GET: api/CartItems/5
		[HttpGet("{id}")]
		public async Task<ActionResult<CartItem>> GetCartItem(int id)
		{
			var cartitem = await _context.CartItems.FirstOrDefaultAsync(t => t.Id == id);

			if (cartitem == null)
			{
				return NotFound();
			}

			return cartitem;
		}

		// PUT: api/CartItems/5
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPut("{id}")]
		public async Task<IActionResult> PutTire(int id, CartItem cartitem)
		{
			if (id != cartitem.Id)
			{
				return BadRequest();
			}

			_context.Entry(cartitem).State = EntityState.Modified;

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
		public async Task<ActionResult<CartItem>> PostTire(CartItem cartitem)
		{
			_context.CartItems.Add(cartitem);
			await _context.SaveChangesAsync();

			return CreatedAtAction(nameof(GetCartItem), new { id = cartitem.Id }, cartitem);
		}

		// DELETE: api/CartItems/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteTire(int id)
		{
			var cartitem = await _context.CartItems.FindAsync(id);
			if (cartitem == null)
			{
				return NotFound();
			}

			_context.CartItems.Remove(cartitem);
			await _context.SaveChangesAsync();

			return NoContent();
		}

		private bool TireExists(int id)
		{
			return _context.CartItems.Any(t => t.Id == id);
		}
	}
}
