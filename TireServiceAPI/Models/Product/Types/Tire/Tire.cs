using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace TireServiceAPI.Models.Product.Types.Tire
{
	public class Tire
	{
		public int Id { get; set; }
		
		public string Name { get; set; }
		public int Price { get; set; }
		
		public string Image { get; set; }
		
		public int BrandId { get; set; }
		
		public int WidthId { get; set; }
		
		public int DiameterId { get; set; }
		
		public int TireSeasonId { get; set; }
				
		public int TireProfileId { get; set; }
	}
}
