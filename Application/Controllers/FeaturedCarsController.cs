using Microsoft.AspNetCore.Mvc;
using Application.Models;
using System.Threading.Tasks;

namespace Application.Controllers
{
    public class FeaturedCarsController : Controller
    {
        private readonly ApplicationDbContext _dbContext; // Renamed to avoid ambiguity  

        public FeaturedCarsController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // Add a new car  
        public async Task<IActionResult> AddCar(Car car)
        {
            _dbContext.Cars.Add(car);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        // Edit an existing car  
        public async Task<IActionResult> EditCar(int id, Car updatedCar)
        {
            var car = await _dbContext.Cars.FindAsync(id);
            if (car == null) return NotFound();

            car.Brand = updatedCar.Brand;
            car.Model = updatedCar.Model;
            car.Year = updatedCar.Year;
            car.Price = updatedCar.Price;
            car.Description = updatedCar.Description;
            car.ImageUrl = updatedCar.ImageUrl;

            await _dbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        // Delete a car  
        public async Task<IActionResult> DeleteCar(int id)
        {
            var car = await _dbContext.Cars.FindAsync(id);
            if (car == null) return NotFound();

            _dbContext.Cars.Remove(car);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}

