using System.ComponentModel.DataAnnotations;

namespace MicroServices.IdentityServer.Dtos
{
    public class SignUpDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
