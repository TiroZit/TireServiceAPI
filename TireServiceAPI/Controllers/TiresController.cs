using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TireServiceAPI.Data;
using TireServiceAPI.Models;

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

    [HttpGet]
    public async Task<ActionResult<List<Tire>>> Get()
    {
      return Ok(await _context.Tires.ToListAsync());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Tire>> Get(int id)
    {
      var Tire = await _context.Tires.FindAsync(id);
      if (Tire == null)
        return BadRequest("Tire not found.");
      return Ok(Tire);
    }

    [HttpPost]
    public async Task<ActionResult<List<Tire>>> AddTire(Tire Tire)
    {
      _context.Tires.Add(Tire);
      await _context.SaveChangesAsync();

      return Ok(await _context.Tires.ToListAsync());
    }

    [HttpPut]
    public async Task<ActionResult<List<Tire>>> UpdateTire(Tire request)
    {
      var dbTire = await _context.Tires.FindAsync(request.Id);
      if (dbTire == null)
        return BadRequest("Tire not found.");

      dbTire.Name = request.Name;
      dbTire.Image = request.Image;
      dbTire.Season = request.Season;
      dbTire.Price = request.Price;
      dbTire.Quantity = request.Quantity;
      dbTire.QuantityCart = request.QuantityCart;
      dbTire.isCart = request.isCart;
      dbTire.isFavorite = request.isFavorite;
      dbTire.isCompare = request.isCompare;

      await _context.SaveChangesAsync();

      return Ok(await _context.Tires.ToListAsync());
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<List<Tire>>> Delete(int id)
    {
      var dbTire = await _context.Tires.FindAsync(id);
      if (dbTire == null)
        return BadRequest("Tire not found.");

      _context.Tires.Remove(dbTire);
      await _context.SaveChangesAsync();

      return Ok(await _context.Tires.ToListAsync());
    }

  }
}