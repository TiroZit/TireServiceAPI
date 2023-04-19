using Microsoft.EntityFrameworkCore;
using TireServiceAPI.Models.Product.Types.Tire;
using TireServiceAPI.Models.Product;
using Microsoft.Extensions.Options;
using TireServiceAPI.Models.Product.Types.Wheel;

public class DataContext : DbContext
{
	public DataContext(DbContextOptions<DataContext> options) : base(options)
	{
	}
	public DbSet<Brand> Brands { get; set; }
	public DbSet<Width> Widths { get; set; }
	public DbSet<Diameter> Diameters { get; set; }
	public DbSet<TireSeason> TireSeasons { get; set; }
	public DbSet<TireProfile> TireProfiles { get; set; }
	public DbSet<WheelType> WheelTypes { get; set; }
	public DbSet<Tire> Tires { get; set; }
	//public DbSet<Wheel> Wheels { get; set; }
}