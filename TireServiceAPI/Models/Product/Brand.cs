using MessagePack;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using TireServiceAPI.Models.Product.Types.Tire;
using TireServiceAPI.Models.Product.Types.Wheel;

namespace TireServiceAPI.Models.Product
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Tire> Tires { get; set; }
		//public ICollection<Wheel> Wheels { get; set; }
	}
}
