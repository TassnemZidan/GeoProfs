using Geoprofs.Enums;

namespace Geoprofs.Models
{

    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public RoleType Role { get; set; }
        public Employee Employee { get; set; }
        public int EmployeeId { get; set; }
    }
}

