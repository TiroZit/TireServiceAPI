using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace TireServiceAPI.Models.Product.Types.Tire
{
	public class Tire
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public Brand TireBrand { get; set; }
		//public int Price { get; set; }
		//public string Image { get; set; }
		//[Key]
		//[ForeignKey("Width")]
		//public int WidthId { get; set; }
		//[ForeignKey("Diameter")]
		//public int DiameterId { get; set; }
		//[ForeignKey("TireSeason")]
		//public int TireSeasonId { get; set; }
		//[ForeignKey("TireProfile")]
		//public int TireProfileId { get; set; }
	}
}
