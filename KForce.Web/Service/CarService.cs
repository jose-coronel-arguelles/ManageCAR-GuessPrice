using KForce.Web.Models;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace KForce.Web.Service;
public class CarService : ICarService
{
    private readonly HttpClient _http;

    private NavigationManager _navigationManager;

    public CarService(HttpClient http, NavigationManager navigationManager) { 
        _http = http;
        _navigationManager = navigationManager; 
    }

    public List<Car> Cars { get; set; } = new List<Car>();

    public async Task CreateCar(Car car)
    {
            var result = await _http.PostAsJsonAsync("http://localhost:5294/API/car/addCar", car);
            _navigationManager.NavigateTo("/");        
    }

    public async Task DeleteCar(Car car)=>await _http.PostAsJsonAsync($"http://localhost:5294/api/car/deletecar", car);

    public async Task<List<Car>> GetCars()
    {
        var result = await _http.GetFromJsonAsync<List<Car>>("http://localhost:5294/api/car/cars");

        if (result != null)
            Cars = result;

        return Cars;
    }

    public async Task<Car> GetSingleCarById(int id)
    {
        var result = await _http.GetFromJsonAsync<Car>($"api/car/carById?id={id}");

        if (result != null)
            return result;

        throw new Exception("Car not found!");
    }

    public async Task UpdateCar(Car car)
    {
            var result = await _http.PostAsJsonAsync($"http://localhost:5294/API/car/editCar", car);
            _navigationManager.NavigateTo("/");        
    }

    private async Task SetCars(HttpResponseMessage result)
    {
        var response = await result.Content.ReadFromJsonAsync<List<Car>>();
        Cars = response;
        _navigationManager.NavigateTo("cars");
    }

}
