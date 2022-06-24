using System.ComponentModel.DataAnnotations;

namespace Geoprofs.Models.Account
{
    public class EditUser
    {
        [Required]
        public string Username { get; set; }

        [MinLength(6, ErrorMessage = "The Password field must be a minimum of 6 characters")]
        public string Password { get; set; }

        public string Role { get; set; }

        public EditUser() { }

        public EditUser(User user)
        {
            Username = user.Username;
            Password = user.Password;
        }
    }
}