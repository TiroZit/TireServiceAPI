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
    public class BrandsController : ControllerBase
    {
		private readonly DataContext _context;

		public BrandsController(DataContext context)
		{
			_context = context;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<Brand>>> GetBrands()
		{
			if (_context.Brands == null)
			{
				return NotFound();
			}
			return await _context.Brands.Include(b => b.Tires).Include(b => b.Wheels).ToListAsync();
		}

		[HttpGet("{id}/tires")]
		public async Task<ActionResult<IEnumerable<Tire>>> GetTires(int id)
		{
			var brand = await _context.Brands.Include(b => b.Tires).Include(b => b.Wheels).FirstOrDefaultAsync(b => b.Id == id);

			if (brand == null)
			{
				return NotFound();
			}

			return Ok(brand.Tires);
		}
	}
}
