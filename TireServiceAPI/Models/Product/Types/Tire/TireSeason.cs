namespace TireServiceAPI.Models.Product.Types.Tire
{
	public class TireSeason
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public List<Tire> Tires { get; set; } = new();
	}
}
