namespace KForce.Web.Models;

public class Car
{
    public int Id { get; set; }

    public string Make { get; set; }

    public string Model { get; set; }

    public int Year { get; set; } = 0;

    public int Door { get; set; }

    public string Color { get; set; }

    public decimal Price { get; set; } = 0;
}
