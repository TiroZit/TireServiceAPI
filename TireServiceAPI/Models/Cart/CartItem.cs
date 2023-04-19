using TireServiceAPI.Models.Product.Types.Tire;
using TireServiceAPI.Models.Product.Types.Wheel;

namespace TireServiceAPI.Models.Cart
{
    public class CartItem
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
		public int CategoryId { get; set; }
		public int? Quantity { get; set; }
	}
}
