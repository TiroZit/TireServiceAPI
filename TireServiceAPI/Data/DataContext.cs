using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TireServiceAPI.Models;

namespace TireServiceAPI.Data
{
    public class DataContext : DbContext
  {
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    public DbSet<Tire> Tires { get; set; }
  }
}
