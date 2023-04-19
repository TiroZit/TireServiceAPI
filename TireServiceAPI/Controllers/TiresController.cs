using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TireServiceAPI.Models.Product.Types.Tire;

namespace TireServiceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TiresController : ControllerBase
    {
        private readonly DataContext _context;

        public TiresController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Tires
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tire>>> GetTires()
        {
          if (_context.Tires == null)
          {
              return NotFound();
          }
            return await _context.Tires.Include(t => t.TireBrand).ToListAsync();
        }

		// GET: api/Tires/5
		[HttpGet("{id}")]
		public async Task<ActionResult<Tire>> GetTire(int id)
		{
			var tire = await _context.Tires.Include(t => t.TireBrand).FirstOrDefaultAsync(t => t.Id == id);

			if (tire == null)
			{
				return NotFound();
			}

			return tire;
		}

		// PUT: api/Tires/5
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPut("{id}")]
		public async Task<IActionResult> PutTire(int id, Tire tire)
		{
			if (id != tire.Id)
			{
				return BadRequest();
			}

			_context.Entry(tire).State = EntityState.Modified;

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

		// POST: api/Tires
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPost]
		public async Task<ActionResult<Tire>> PostTire(Tire tire)
		{
			_context.Tires.Add(tire);
			await _context.SaveChangesAsync();

			return CreatedAtAction(nameof(GetTire), new { id = tire.Id }, tire);
		}

		// DELETE: api/Tires/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteTire(int id)
		{
			var tire = await _context.Tires.FindAsync(id);
			if (tire == null)
			{
				return NotFound();
			}

			_context.Tires.Remove(tire);
			await _context.SaveChangesAsync();

			return NoContent();
		}

		private bool TireExists(int id)
		{
			return _context.Tires.Any(t => t.Id == id);
		}
	}
}
