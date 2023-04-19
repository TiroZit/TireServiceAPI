using TireServiceAPI.Models.Product.Types.Tire;
using TireServiceAPI.Models.Product.Types.Wheel;

namespace TireServiceAPI.Models.Product
{
    public class Width
    {
        public int Id { get; set; }
        public string? Name { get; set; }
		public List<Tire> Tires { get; set; } = new(); 
        public List<Wheel> Wheels { get; set; } = new();
	}
}
