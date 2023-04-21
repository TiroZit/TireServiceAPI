using TireServiceAPI.Models.Cart;

namespace TireServiceAPI.Models.Product.Types.Wheel
{
    public class Wheel
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

		public string? WheelType { get; set; }
		public WheelType? WheelTypes { get; set; }

		public string? WheelCategory { get; set; }
		public WheelCategory? WheelCategories { get; set; }
	}
}
