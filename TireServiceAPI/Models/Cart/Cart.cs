using TireServiceAPI.Models.Product.Types.Tire;
using TireServiceAPI.Models.Product.Types.Wheel;

namespace TireServiceAPI.Models.Cart
{
    public class Cart
    {
        public int Id { get; set; }
		public int UserId { get; set; }
		public List<CartItem> CartItems { get; set; } = new List<CartItem>();
	}
}
