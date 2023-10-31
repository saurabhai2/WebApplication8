using System.ComponentModel.DataAnnotations;

namespace WebApplication8.Models
{
    
    public class Login
    {
        [Key]
        public int Id { get; set;}
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

    }

    public class Register
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }

    }
}
