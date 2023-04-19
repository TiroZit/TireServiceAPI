using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TireServiceAPI.Models.Product.Types.Wheel
{
    public class Wheel
    {
		public int Id { get; set; }
		[ForeignKey("Brand")]
		public int BrandId { get; set; }
		public string? Name { get; set; }
		public int Price { get; set; }
		public string? Image { get; set; }
		[ForeignKey("Width")]
		public int WidthId { get; set; }
		[ForeignKey("Diameter")]
		public int DiameterId { get; set; }
		[ForeignKey("WheelType")]
		public int WheelTypeId { get; set; }
	}
}
