using Microsoft.EntityFrameworkCore;
using TireServiceAPI.Models.Product.Types.Tire;
using TireServiceAPI.Models.Product;
using Microsoft.Extensions.Options;

public class DataContext : DbContext
{
	public DataContext(DbContextOptions<DataContext> options) : base(options)
	{
	}
	public DbSet<Brand> Brands { get; set; }
	public DbSet<Tire> Tires { get; set; }
	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		var tires = modelBuilder.Entity<Tire>();

		tires
			.HasOne(b => b.TireBrand)
			.WithMany(a => a.Tires)
			.HasForeignKey("Id_TireBrand")
			.IsRequired();
	}
}