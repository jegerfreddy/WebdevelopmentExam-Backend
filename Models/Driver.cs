using System.ComponentModel.DataAnnotations;
using F1API.Interfaces;

namespace F1API.Models;

public class Driver : IDriver
{
    [Key]
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Age { get; set; }
    public string? Nationality { get; set; }
    public string? Image { get; set; }
}