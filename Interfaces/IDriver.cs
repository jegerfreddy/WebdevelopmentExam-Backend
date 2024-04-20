using System.ComponentModel.DataAnnotations;

namespace F1API.Interfaces;

public interface IDriver
{
    [Key]
    int Id { get; set; }
    string? Name { get; set; }
    int Age { get; set; }
    string? Nationality { get; set; }
    string? Image { get; set; }
}