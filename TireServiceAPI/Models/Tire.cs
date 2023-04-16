namespace TireServiceAPI.Models
{
    public class Tire
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public string Season { get; set; } = string.Empty;
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int QuantityCart { get; set; }
        public bool isCart { get; set; }
        public bool isFavorite { get; set; }
        public bool isCompare { get; set; }
    }
}