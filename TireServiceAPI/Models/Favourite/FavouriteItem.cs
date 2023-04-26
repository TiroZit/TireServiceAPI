using System.Text.Json.Serialization;
using TireServiceAPI.Models.Product.Types.Tire;
using TireServiceAPI.Models.Product.Types.Wheel;

namespace TireServiceAPI.Models.Favourite
{
    public class FavouriteItem
    {
        public int Id { get; set; }
		public int FavouriteId { get; set; }
		[JsonIgnore]
		public Favourite? Favourites { get; set; }
		public string? CategoryName { get; set; }
		public Tire? Tire { get; set; }
		public int? TireId { get; set; }
		public int? WheelId { get; set; }
		public Wheel? Wheel { get; set; }
	}
}
