namespace Application.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public int DurationMinutes { get; set; }
        public string? ImageUrl { get; set; }
        public DateTime CreatedAt { get; set; }
    }

}
