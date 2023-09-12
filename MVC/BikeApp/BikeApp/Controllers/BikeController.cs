using BikeApp.Mapper;
using BikeApp.Models.Domain;
using BikeApp.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BikeApp.Controllers
{
    public class BikeController : Controller
    {
        public IActionResult GetAllBikes()
        {

            List<BikeViewModel> filteredBikes = StaticDb.Bikes.Select(bike => bike.ToBikeViewModel()).ToList();

            return View(filteredBikes);
        }

        public IActionResult GetAllBikesWithHydraulicBreaks()
        {
            List<Bike> bikes = StaticDb.Bikes;

            List<BikeViewModel> filteredBikes = StaticDb.Bikes.Where(bike => bike.HasHydraulicBreaks).Select(bike => bike.ToBikeViewModel()).ToList();

            return View(filteredBikes);
        }

        public IActionResult GetBikeById(int? Id)
        {
            if(Id == null)
            {
                return RedirectToAction("Error");
            }

            BikeViewModel bikes = StaticDb.Bikes.FirstOrDefault(bikes => bikes.Id == Id).ToBikeViewModel();

            if(bikes == null)
            {
                return RedirectToAction("Error");
            }

            return View(bikes);
        }

        public IActionResult DeleteBikes(int? Id)
        {
            Bike bike = StaticDb.Bikes.FirstOrDefault(bikes => bikes.Id == Id);
            StaticDb.Bikes.Remove(bike);

            ViewBag.ConfirmationMessage = $"Item with id {bike.Id} has been deleted";

            return View();
        }
    }
}
