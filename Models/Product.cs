using System.ComponentModel.DataAnnotations;
namespace EcomAssignment3.Models;
public class Product
{
    [Key]
    public int ID {get; set;}
    public string Description { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;
}
