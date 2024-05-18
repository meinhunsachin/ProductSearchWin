using System.ComponentModel.DataAnnotations;

namespace ProductSearch.Models;

public class Product
{
    public int Id { get; set; }
    public string? ProductName { get; set; }
    public string? Size { get; set; }
    public int Price { get; set; }
    [DataType(DataType.Date)]
    public DateTime MfgDate { get; set; }
    public string? Category { get; set; }
}