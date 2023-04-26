using System.Text.Json.Serialization;
using TireServiceAPI.Models.Cart;
using TireServiceAPI.Models.Favourite;

namespace TireServiceAPI.Models.Product.Types.Tire
{
	public class Tire
	{
		public int Id { get; set; }
		
		public string? Name { get; set; }
		public int Price { get; set; }
		
		public string? Image { get; set; }
		
		public string? Brand { get; set; }
		[JsonIgnore]
		public Brand? Brands { get; set; }

		public string? Width { get; set; }
		[JsonIgnore]
		public Width? Widths { get; set; }

		public string? Diameter { get; set; }
		[JsonIgnore]
		public Diameter? Diameters { get; set; }

		public string? TireSeason { get; set; }
		[JsonIgnore]
		public TireSeason? TireSeasons { get; set; }

		public string? TireProfile { get; set; }
		[JsonIgnore]
		public TireProfile? TireProfiles { get; set; }

		public string? TireCategory { get; set; }
		[JsonIgnore]
		public TireCategory? TireCategories { get; set; }
		[JsonIgnore]
		public List<CartItem> cartItems { get; set; } = new List<CartItem>();
		[JsonIgnore]
		public List<FavouriteItem> FavouriteItems { get; set; } = new List<FavouriteItem>();
	}
}
