using KForce.Service.Model;
using KForce.Service.Service;
using Microsoft.AspNetCore.Mvc;

namespace CarDirectoryAPI.Controllers;

[ApiController]
[Route("/API/Car")]
public class CarsController : Controller
{
    private readonly IGenericService<Car> _carService;

    public CarsController(IGenericService<Car> carService)
        =>_carService = carService;

    [HttpGet]
    [Route("cars")]
    public IActionResult GetCars()
    {
        var result = _carService.GetAll();
        return Json(result);
    }
    
    [HttpGet]
    [Route("carById")]
    public IActionResult GetCarByNumber(int id)
    {
        var result = _carService.GetById(id);
        return Json(result);
    }

    [HttpPost]
    [Route("addCar")]
    public IActionResult AddCar(Car car)
    {
            var result = _carService.Add(car);
            return Ok(result);            
    }

    [HttpPost]
    [Route("editCar")]
    public IActionResult EditCar(Car car)
    {
        var result = _carService.Update(car);
        return Ok(result);
    }

    [HttpPost]
    [Route("deleteCar")]
    public IActionResult DeleteCar(Car car)
    {
        var result = _carService.Delete(car);
        return Ok(result);
    }

}