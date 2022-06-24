using Geoprofs.Enums;
using System;
using System.Collections.Generic;

namespace Geoprofs.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public int BSN { get; set; }
        public DateTime StartDate { get; set; }
        public PositionType PositionType { get; set; }
        public Employee? Supervisor { get; set; }
        public int? SupervisorId { get; set; }
        public List<Employee> Employees { get; set; }
        public int VacationBalance {get; set; }
        public ICollection<User> Users { get; set; }
        public ICollection<Register> Registers { get; set; }

    }
}
