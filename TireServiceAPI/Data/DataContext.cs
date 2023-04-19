using Microsoft.EntityFrameworkCore;
using TireServiceAPI.Models.Product.Types.Tire;
using TireServiceAPI.Models.Product;
using TireServiceAPI.Models.Product.Types.Wheel;
using TireServiceAPI.Models.Cart;

public class DataContext : DbContext
{
	public DataContext(DbContextOptions<DataContext> options) : base(options)
	{
	}
	// Общие свойства товаров
	public DbSet<Brand> Brands { get; set; } = null!;
	public DbSet<Width> Widths { get; set; } = null!;
	public DbSet<Diameter> Diameters { get; set; } = null!;

	// Шины
	public DbSet<Tire> Tires { get; set; } = null!;
	public DbSet<TireSeason> TireSeasons { get; set; } = null!;
	public DbSet<TireProfile> TireProfiles { get; set; } = null!;
	public DbSet<TireCategory> TireCategories { get; set; } = null!;

	// Диски
	public DbSet<Wheel> Wheels { get; set; } = null!;
	public DbSet<WheelType> WheelTypes { get; set; } = null!;
	public DbSet<WheelCategory> WheelCategories { get; set; } = null!;

	// Корзина
	public DbSet<Cart> Carts { get; set; } = null!;
	public DbSet<CartItem> CartItems { get; set; } = null!;

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Tire>()
			.HasOne(t => t.Brands)
			.WithMany(b => b.Tires)
			.HasForeignKey(t => t.Brand)
			.HasPrincipalKey(b => b.Name);

		modelBuilder.Entity<Tire>()
			.HasOne(t => t.Widths)
			.WithMany(b => b.Tires)
			.HasForeignKey(t => t.Width)
			.HasPrincipalKey(b => b.Name);

		modelBuilder.Entity<Tire>()
			.HasOne(t => t.Diameters)
			.WithMany(b => b.Tires)
			.HasForeignKey(t => t.Diameter)
			.HasPrincipalKey(b => b.Name);

		modelBuilder.Entity<Tire>()
			.HasOne(t => t.TireSeasons)
			.WithMany(b => b.Tires)
			.HasForeignKey(t => t.TireSeason)
			.HasPrincipalKey(b => b.Name);

		modelBuilder.Entity<Tire>()
			.HasOne(t => t.TireProfiles)
			.WithMany(b => b.Tires)
			.HasForeignKey(t => t.TireProfile)
			.HasPrincipalKey(b => b.Name);

		modelBuilder.Entity<Tire>()
			.HasOne(t => t.TireCategories)
			.WithMany(b => b.Tires)
			.HasForeignKey(t => t.TireCategory)
			.HasPrincipalKey(b => b.Name);

		modelBuilder.Entity<Wheel>()
			.HasOne(t => t.Brands)
			.WithMany(b => b.Wheels)
			.HasForeignKey(t => t.Brand)
			.HasPrincipalKey(b => b.Name);

		modelBuilder.Entity<Wheel>()
			.HasOne(t => t.Widths)
			.WithMany(b => b.Wheels)
			.HasForeignKey(t => t.Width)
			.HasPrincipalKey(b => b.Name);

		modelBuilder.Entity<Wheel>()
			.HasOne(t => t.Diameters)
			.WithMany(b => b.Wheels)
			.HasForeignKey(t => t.Diameter)
			.HasPrincipalKey(b => b.Name);

		modelBuilder.Entity<Wheel>()
			.HasOne(t => t.WheelTypes)
			.WithMany(b => b.Wheels)
			.HasForeignKey(t => t.WheelType)
			.HasPrincipalKey(b => b.Name);

		modelBuilder.Entity<Wheel>()
			.HasOne(t => t.WheelCategories)
			.WithMany(b => b.Wheels)
			.HasForeignKey(t => t.WheelCategory)
			.HasPrincipalKey(b => b.Name);

		// Cart
		modelBuilder.Entity<CartItem>()
			.HasOne(t => t.Carts)
			.WithMany(b => b.CartItems)
			.HasForeignKey(t => t.CartId);
	}
}