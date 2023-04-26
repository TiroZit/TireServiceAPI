using System.Text.Json.Serialization;
using TireServiceAPI.Models.Cart;
using TireServiceAPI.Models.Favourite;

namespace TireServiceAPI.Models.Product.Types.Wheel
{
    public class Wheel
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

		public string? WheelType { get; set; }
		[JsonIgnore]
		public WheelType? WheelTypes { get; set; }

		public string? WheelCategory { get; set; }
		[JsonIgnore]
		public WheelCategory? WheelCategories { get; set; }
		[JsonIgnore]
		public List<CartItem> cartItems { get; set; } = new List<CartItem>();
		[JsonIgnore]
		public List<FavouriteItem> FavouriteItems { get; set; } = new List<FavouriteItem>();
	}
}
