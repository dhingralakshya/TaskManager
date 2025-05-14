using System.ComponentModel.DataAnnotations;

namespace TaskManagerApp.Models
{
    public class AdminLoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;

        [Required]
        public string AdminCode { get; set; } = string.Empty;
    }
}