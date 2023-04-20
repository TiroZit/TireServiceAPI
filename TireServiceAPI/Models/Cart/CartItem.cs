namespace TireServiceAPI.Models.Cart
{
    public class CartItem
    {
        public int Id { get; set; }
		public int CartId { get; set; }
		public Cart? Carts { get; set; }
		public int ProductId { get; set; }
		public string CategoryName { get; set; }
		public int Quantity { get; set; }
	}
}
