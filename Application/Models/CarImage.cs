namespace Application.Models
{
    public class CarImage
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public string ImageUrl { get; set; } = null!;
        public Car Car { get; set; } = null!;
    }

}
