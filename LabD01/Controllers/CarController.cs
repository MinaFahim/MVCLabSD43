using LabD01.Models;
using Microsoft.AspNetCore.Mvc;

namespace LabD01.Controllers
{
    public class CarController : Controller
    {
        public IActionResult GetAll()
        {
            var cars = Car.GetCars();
            return View(cars);
        } public IActionResult GetDetial(string model,string type)
        {
            var cars = Car.GetCars().First(e=>e.Model == model);
            var cardata = new { type, cars };
            return View(cardata);  
           
            
        }
    }
}
