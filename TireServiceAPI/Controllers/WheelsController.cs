using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using TireServiceAPI.Models.Product.Types.Wheel;

namespace TireServiceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WheelsController : ControllerBase
    {
        private readonly DataContext _context;

        public WheelsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Wheels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Wheel>>> GetTires()
        {
          if (_context.Wheels == null)
          {
              return NotFound();
          }
            return await _context.Wheels.ToListAsync();
        }

		// GET: api/Wheels/5
		[HttpGet("{id}")]
		public async Task<ActionResult<Wheel>> GetTire(int id)
		{
			var wheel = await _context.Wheels.FirstOrDefaultAsync(t => t.Id == id);

			if (wheel == null)
			{
				return NotFound();
			}

			return wheel;
		}

		// PUT: api/Wheels/5
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPut("{id}")]
		public async Task<IActionResult> PutTire(int id, Wheel wheel)
		{
			if (id != wheel.Id)
			{
				return BadRequest();
			}

			_context.Entry(wheel).State = EntityState.Modified;

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

		// POST: api/Wheels
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPost]
		public async Task<ActionResult<Wheel>> PostTire(Wheel wheel)
		{
			_context.Wheels.Add(wheel);
			await _context.SaveChangesAsync();

			return CreatedAtAction(nameof(GetTire), new { id = wheel.Id }, wheel);
		}

		// DELETE: api/Wheels/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteTire(int id)
		{
			var wheel = await _context.Wheels.FindAsync(id);
			if (wheel == null)
			{
				return NotFound();
			}

			_context.Wheels.Remove(wheel);
			await _context.SaveChangesAsync();

			return NoContent();
		}

		private bool TireExists(int id)
		{
			return _context.Wheels.Any(t => t.Id == id);
		}
	}
}
