using System.ComponentModel.DataAnnotations;

namespace Geoprofs.Models.Account
{
    public class AddUser
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int Role { get; set; }

        [Required]
        [MinLength(6, ErrorMessage = "The Password field must be a minimum of 6 characters")]
        public string Password { get; set; }
    }
}