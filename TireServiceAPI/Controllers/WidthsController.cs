using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TireServiceAPI.Models.Product;
using TireServiceAPI.Models.Product.Types.Tire;

namespace TireServiceAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class WidthsController : ControllerBase
	{
		private readonly DataContext _context;

		public WidthsController(DataContext context)
		{
			_context = context;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<Width>>> GetWidths()
		{
			if (_context.Widths == null)
			{
				return NotFound();
			}
			return await _context.Widths.Include(b => b.Tires).ToListAsync();
		}

		[HttpGet("{id}/tires")]
		public async Task<ActionResult<IEnumerable<Tire>>> GetTires(int id)
		{
			var Width = await _context.Widths.Include(b => b.Tires).FirstOrDefaultAsync(b => b.Id == id);

			if (Width == null)
			{
				return NotFound();
			}

			return Ok(Width.Tires);
		}
	}
}
