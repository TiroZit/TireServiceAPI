using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TireServiceAPI.Models.Product.Types.Wheel
{
    public class WheelType
    {
		public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
		public ICollection<Wheel> Wheels { get; set; }
	}
}
