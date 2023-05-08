using KForce.Service.Model;
using Microsoft.EntityFrameworkCore;

namespace KForce.Service.Data;

public class DbInitializer
{
    private readonly ModelBuilder _builder;

    public DbInitializer(ModelBuilder builder)=>_builder = builder;

    public void Seed()
    {
        _builder.Entity<Car>(a =>
        {
            a.HasData(new Car
            {
                Id = 1,
                Make = "Audi",
                Model = "R8",
                Year = 2018,
                Door = 2,
                Color = "Red",
                Price = 79995,
            });
            a.HasData(new Car
            {
                Id = 2,
                Make = "Tesla",
                Model = "3",
                Year = 2018,
                Door = 4,
                Color = "Black",
                Price = 54995,
            });
            a.HasData(new Car
            {
                Id = 3,
                Make = "Porshe",
                Model = "911 991",
                Year = 2020,
                Door = 2,
                Color = "White",
                Price = 155000,
            });
            a.HasData(new Car
            {
                Id = 4,
                Make = "Mercedes-Benz",
                Model = "GLE 63S",
                Year = 2021,
                Door = 5,
                Color = "Blue",
                Price = 83995,
            });
            a.HasData(new Car
            {
                Id = 5,
                Make = "BMW",
                Model = "X6 M",
                Year = 2020,
                Door = 5,
                Color = "Silver",
                Price = 62995,
            });
        });

    }
}
