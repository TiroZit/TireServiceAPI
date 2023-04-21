using TireServiceAPI.Models.Product.Types.Tire;
using TireServiceAPI.Models.Product.Types.Wheel;

namespace TireServiceAPI.Models.Cart
{
    public class Cart
    {
        public int Id { get; set; }
		public int UserId { get; set; }
		public ICollection<CartItem> CartItems { get; set; }
	}
}
