using System.ComponentModel.DataAnnotations;

namespace KForce.Service.Model;

public class Car
{
    [Key]
    public int Id { get; set; }
    
    [Required(ErrorMessage ="Make is required")]
    public string Make { get; set; }
    
    [Required(ErrorMessage = "Model is required")]
    public string Model { get; set; }
    
    [Required(ErrorMessage = "Year is required")]
    public int Year { get; set; }

    [Required(ErrorMessage = "Door is required")]
    public int Door { get; set; }

    [Required(ErrorMessage = "Color is required")]
    public string Color { get; set; }

    [Required(ErrorMessage = "Price is required")]
    public decimal Price { get; set; }
}
