using System.ComponentModel.DataAnnotations;

namespace API.DTO;

public class RegisterDTO
{
    [MaxLength(100)]
    [Required]
    public required string Username { get; set; }
    [Required]
    public required string Password { get; set; }
}