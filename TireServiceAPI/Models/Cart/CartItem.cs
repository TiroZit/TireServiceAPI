using System.Text.Json.Serialization;
using TireServiceAPI.Models.Product.Types.Tire;
using TireServiceAPI.Models.Product.Types.Wheel;

namespace TireServiceAPI.Models.Cart
{
    public class CartItem
    {
        public int Id { get; set; }
		public int CartId { get; set; }
		[JsonIgnore]
		public Cart? Carts { get; set; }
		public string? CategoryName { get; set; }
		public int Quantity { get; set; }
		public Tire? Tire { get; set; }
		public int? TireId { get; set; }
		public int? WheelId { get; set; }
		public Wheel? Wheel { get; set; }
	}
}
