using TireServiceAPI.Models.Product.Types.Tire;
using TireServiceAPI.Models.Product.Types.Wheel;

namespace TireServiceAPI.Models.Product
{
    public class Width
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
		public ICollection<Tire> Tires { get; set; }
		//public ICollection<Wheel> Wheels { get; set; }
	}
}
