using KForce.Web.Models;

namespace KForce.Web.Service;

public interface ICarService
{
    List<Car> Cars { get; set; }

    Task<List<Car>> GetCars();

    Task<Car> GetSingleCarById(int id);

    Task CreateCar(Car car);

    Task UpdateCar(Car car);

    Task DeleteCar(Car car);

}
