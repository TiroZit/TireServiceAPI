namespace TireServiceAPI.Models.Product.Types.Wheel
{
	public class WheelCategory
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public List<Wheel> Wheels { get; set; } = new();
	}
}
