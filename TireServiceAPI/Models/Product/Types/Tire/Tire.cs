using System.Text.Json.Serialization;
using TireServiceAPI.Models.Cart;

namespace TireServiceAPI.Models.Product.Types.Tire
{
	public class Tire
	{
		public int Id { get; set; }
		
		public string? Name { get; set; }
		public int Price { get; set; }
		
		public string? Image { get; set; }
		
		public string? Brand { get; set; }
		public Brand? Brands { get; set; }

		public string? Width { get; set; }
		public Width? Widths { get; set; }

		public string? Diameter { get; set; }
		public Diameter? Diameters { get; set; }

		public string? TireSeason { get; set; }
		public TireSeason? TireSeasons { get; set; }

		public string? TireProfile { get; set; }
		public TireProfile? TireProfiles { get; set; }

		public string? TireCategory { get; set; }
		public TireCategory? TireCategories { get; set; }
		[JsonIgnore]
		public List<CartItem> cartItems { get; set; } = new List<CartItem>();
	}
}
