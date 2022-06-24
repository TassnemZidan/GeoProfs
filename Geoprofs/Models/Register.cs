using Geoprofs.Enums;
using System;

namespace Geoprofs.Models
{
    public class Register
    {
        public int Id { get; set; }
        public Employee Employee { get; set; }
        public int EmployeeId { get; set; }
        public TypeLeave TypeLeave  { get; set; }
        public string Note { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsApproved { get; set; }
    }
       
}
