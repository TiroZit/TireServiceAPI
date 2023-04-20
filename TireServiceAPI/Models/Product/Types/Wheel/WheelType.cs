namespace TireServiceAPI.Models.Product.Types.Wheel
{
    public class WheelType
    {
		public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
		public List<Wheel> Wheels { get; set; } = new();
	}
}
