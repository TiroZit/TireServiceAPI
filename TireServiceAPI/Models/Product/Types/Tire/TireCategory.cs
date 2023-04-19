namespace TireServiceAPI.Models.Product.Types.Tire
{
	public class TireCategory
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public List<Tire> Tires { get; set; } = new();
	}
}
