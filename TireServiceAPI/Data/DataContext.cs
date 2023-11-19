using Microsoft.EntityFrameworkCore;
using TireServiceAPI.Models.Product.Types.Tire;
using TireServiceAPI.Models.Product;
using TireServiceAPI.Models.Product.Types.Wheel;
using TireServiceAPI.Models.Cart;
using TireServiceAPI.Models.Favourite;

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

	// Избранное
	public DbSet<Favourite> Favourites { get; set; } = null!;
	public DbSet<FavouriteItem> FavouriteItems { get; set; } = null!;

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Brand>().HasData(
			new Brand { Id = 1, Name = "KAMA" },
			new Brand { Id = 2, Name = "ROYALBLACK" },
			new Brand { Id = 3, Name = "FORMULA" }
		);

		modelBuilder.Entity<Width>().HasData(
			new Width { Id = 1, Name = "135" },
			new Width { Id = 2, Name = "155" },
			new Width { Id = 3, Name = "175" },
			new Width { Id = 4, Name = "185" },
			new Width { Id = 5, Name = "195" },
			new Width { Id = 6, Name = "205" }
		);
		
		modelBuilder.Entity<Diameter>().HasData(
			new Diameter { Id = 1, Name = "12" },
			new Diameter { Id = 2, Name = "13" },
			new Diameter { Id = 3, Name = "14" },
			new Diameter { Id = 4, Name = "15" },
			new Diameter { Id = 5, Name = "16" },
			new Diameter { Id = 6, Name = "17" },
			new Diameter { Id = 7, Name = "18" },
			new Diameter { Id = 8, Name = "19" },
			new Diameter { Id = 9, Name = "20" }
		);
		
		modelBuilder.Entity<TireSeason>().HasData(
			new TireSeason { Id = 1, Name = "Зимние  нешипованные" },
			new TireSeason { Id = 2, Name = "Зимние  шипованные" },
			new TireSeason { Id = 3, Name = "Летние" }
		);
		
		modelBuilder.Entity<TireProfile>().HasData(
			new TireProfile { Id = 1, Name = "50" },
			new TireProfile { Id = 2, Name = "55" },
			new TireProfile { Id = 3, Name = "60" },
			new TireProfile { Id = 4, Name = "65" },
			new TireProfile { Id = 5, Name = "70" },
			new TireProfile { Id = 6, Name = "75" },
			new TireProfile { Id = 7, Name = "80" },
			new TireProfile { Id = 8, Name = "85" }
		);
		
		modelBuilder.Entity<TireCategory>().HasData(
			new TireCategory { Id = 1, Name = "Легковые" },
			new TireCategory { Id = 2, Name = "Легкогрузовые" },
			new TireCategory { Id = 3, Name = "Грузовые" },
			new TireCategory { Id = 4, Name = "Сельхозшины" },
			new TireCategory { Id = 5, Name = "Спецшины" }
		);
		
		modelBuilder.Entity<Tire>().HasData(
			new Tire 
			{ 
				Id = 1,
				Name = "Breeze (НК-132) TL",
				Image = "tires/1.png",
				Price = 2640,
				Brand = "KAMA",
				Width = "175",
				Diameter = "14",
				TireSeason = "Летние",
				TireProfile = "65",
				TireCategory = "Легковые"
			},
			new Tire 
			{ 
				Id = 2,
				Name = "Breeze (НК-132) TL",
				Image = "tires/2.png",
				Price = 2660,
				Brand = "KAMA",
				Width = "175",
				Diameter = "13",
				TireSeason = "Летние",
				TireProfile = "70",
				TireCategory = "Легковые"
			},
			new Tire 
			{ 
				Id = 3,
				Name = "Кама-365 (НК-241) TL",
				Image = "tires/3.png",
				Price = 2700,
				Brand = "KAMA",
				Width = "175",
				Diameter = "14",
				TireSeason = "Летние",
				TireProfile = "65",
				TireCategory = "Легковые"
			},
			new Tire 
			{ 
				Id = 4,
				Name = "Royalmile TL",
				Image = "tires/4.png",
				Price = 2710,
				Brand = "ROYALBLACK",
				Width = "175",
				Diameter = "15",
				TireSeason = "Летние",
				TireProfile = "70",
				TireCategory = "Легковые"
			},
			new Tire 
			{ 
				Id = 5,
				Name = "Кама-365 (НК-241) TL",
				Image = "tires/5.png",
				Price = 3011,
				Brand = "KAMA",
				Width = "195",
				Diameter = "17",
				TireSeason = "Летние",
				TireProfile = "55",
				TireCategory = "Легковые"
			},
			new Tire 
			{ 
				Id = 6,
				Name = "Grant (НК-241) TL",
				Image = "tires/6.png",
				Price = 2988,
				Brand = "KAMA",
				Width = "205",
				Diameter = "13",
				TireSeason = "Зимние  нешипованные",
				TireProfile = "60",
				TireCategory = "Легковые"
			},
			new Tire 
			{ 
				Id = 7,
				Name = "ОШЗ ИЯ-112А",
				Image = "tires/specials/1.png",
				Price = 10600,
				Brand = "FORMULA",
				Width = "135",
				Diameter = "15",
				TireSeason = "Зимние  шипованные",
				TireProfile = "50",
				TireCategory = "Грузовые"
			},
			new Tire 
			{ 
				Id = 8,
				Name = "ОШЗ У-2",
				Image = "tires/specials/2.png",
				Price = 12033,
				Brand = "FORMULA",
				Width = "155",
				Diameter = "15",
				TireSeason = "Летние",
				TireProfile = "65",
				TireCategory = "Грузовые"
			},
			new Tire 
			{ 
				Id = 9,
				Name = "BKT FL-252",
				Image = "tires/specials/3.png",
				Price = 4481,
				Brand = "ROYALBLACK",
				Width = "195",
				Diameter = "17",
				TireSeason = "Летние",
				TireProfile = "70",
				TireCategory = "Спецшины"
			},
			new Tire 
			{ 
				Id = 10,
				Name = "solid /std/ Starco Tusker TL",
				Image = "tires/specials/4.png",
				Price = 5442,
				Brand = "FORMULA",
				Width = "195",
				Diameter = "14",
				TireSeason ="Зимние  нешипованные",
				TireProfile = "55",
				TireCategory = "Спецшины"
			}
		);

		modelBuilder.Entity<WheelType>().HasData(
			new WheelType { Id = 1, Name = "Легкосплавный" },
			new WheelType { Id = 2, Name = "Стальной" }
		);
		
		modelBuilder.Entity<WheelCategory>().HasData(
			new WheelCategory { Id = 1, Name = "Легковые" },
			new WheelCategory { Id = 2, Name = "Грузовые" }
		);

		modelBuilder.Entity<Wheel>().HasData(
			new Wheel
			{
				Id = 1,
				Name = "T.Corolla (53A38R) box Silver (TREBL)",
				Image = "1",
				Price = 2640,
				Brand = "FORMULA",
				Width = "175",
				Diameter = "13",
				WheelType = "Легкосплавный",
				WheelCategory = "Легковые"
			},
			new Wheel
			{
				Id = 2,
				Name = "ВАЗ-2112 Silver (ТЗСК, Тольятти)",
				Image = "wheels/1.png",
				Price = 2660,
				Brand = "KAMA",
				Width = "195",
				Diameter = "17",
				WheelType = "Легкосплавный",
				WheelCategory = "Легковые"
			},
			new Wheel
			{
				Id = 3,
				Name = "Skoda, VW (63H37D-PCR14605100R) S (Eurodisk)",
				Image = "wheels/2.png",
				Price = 4040,
				Brand = "ROYALBLACK",
				Width = "205",
				Diameter = "13",
				WheelType = "Стальной",
				WheelCategory = "Грузовые"
			},
			new Wheel
			{
				Id = 4,
				Name = "Royalmile TL",
				Image = "wheels/3.png",
				Price = 2710,
				Brand = "ROYALBLACK",
				Width = "175",
				Diameter = "15",
				WheelType = "Стальной",
				WheelCategory = "Грузовые"
			},
			new Wheel
			{
				Id = 5,
				Name = "(AR006) box Silver (TREBL)",
				Image = "wheels/4.png",
				Price = 46040,
				Brand = "KAMA",
				Width = "175",
				Diameter = "14",
				WheelType = "Легкосплавный",
				WheelCategory = "Легковые"
			}
		);

		modelBuilder.Entity<Cart>().HasData(
			new Cart { Id = 1, UserId = 1 }
		);

		modelBuilder.Entity<Favourite>().HasData(
			new Favourite { Id = 1, UserId = 1 }
		);

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
	}
}