using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TireServiceAPI.Models.Product.Types.Wheel
{
    public class Wheel
    {
		public int Id { get; set; }
		public string? Name { get; set; }
		public int Price { get; set; }
		public string? Image { get; set; }
		public Brand Brand { get; set; }
		public Width Width { get; set; }
		public Diameter Diameter { get; set; }
		public WheelType WheelType { get; set; }
	}
}
