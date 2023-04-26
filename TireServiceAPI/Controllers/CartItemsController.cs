using Azure.Core;
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
		public async Task<ActionResult<List<CartItem>>> Get()
		{
			if (_context.CartItems == null)
			{
				return NotFound();
			}
			return await _context.CartItems.Include(c => c.Tire).Include(c => c.Wheel).ToListAsync();
		}

		// GET: api/CartItems/5
		[HttpGet("{id}")]
		public async Task<ActionResult<CartItem>> GetCartItem(int id)
		{
			var cartitem = await _context.CartItems.Include(c => c.Tire).Include(c => c.Wheel).FirstOrDefaultAsync(t => t.Id == id);

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
		public async Task<ActionResult<CartItem>> PostTire(CartItem cartItem)
		{
			// Проверяем, есть ли уже такой элемент в корзине
			var existingItem = await _context.CartItems.FirstOrDefaultAsync(ci => ci.TireId == cartItem.TireId);
			if (existingItem != null)
			{
				// Если элемент уже есть в корзине, увеличиваем его количество
				existingItem.Quantity += cartItem.Quantity;
				_context.Entry(existingItem).State = EntityState.Modified;
				await _context.SaveChangesAsync();
				return existingItem;
			}
			else
			{
				// Если элемента еще нет в корзине, добавляем его
				_context.CartItems.Add(cartItem);
				await _context.SaveChangesAsync();
				return CreatedAtAction(nameof(GetCartItem), new { id = cartItem.Id }, cartItem);
			}
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
