using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TireServiceAPI.Models.Product.Types.Tire
{
	public class TireProfile
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
	}
}
