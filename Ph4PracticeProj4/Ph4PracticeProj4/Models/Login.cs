using System.ComponentModel.DataAnnotations;

namespace Ph4PracticeProj4.Models
{
    public class Login
    {

        [Required]
        public string? Username { get; set; }
        [Required]
        public string? Password { get; set; }
    }
}
