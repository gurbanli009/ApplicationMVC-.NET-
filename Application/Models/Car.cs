namespace Application.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; } = null!;
        public string Model { get; set; } = null!;
        public int Year { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; } = null!;
        public string? ImageUrl { get; set; }
        public DateTime CreatedAt { get; set; }

        public ICollection<CarImage> Images { get; set; } = new List<CarImage>();
    }

}
