using System.ComponentModel.DataAnnotations;

namespace F1.Interfaces;

public interface IRace
{
    [Key]
    int Id { get; set; }
    string? PlayerName { get; set; }
    int Score { get; set; }
}