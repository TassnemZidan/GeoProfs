using Geoprofs.Enums;
using Geoprofs.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Geoprofs.Data
{
    public class DbContexts : DbContext
    {
        public DbContexts(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Register> Registers { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring (optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            var employees = new Employee[]
           {
            new Employee{Id = 1, Name = "Sandra" , Lastname = "Leeuwen", BSN = 2595714 ,StartDate = new System.DateTime(2008,5,25), PositionType = PositionType.Employee, SupervisorId = null, VacationBalance = 160 },
            new Employee{Id = 2, Name = "Jarno" ,Lastname="Anders", BSN= 2375648 ,StartDate = new System.DateTime(2001,9,25), PositionType = PositionType.Manager, SupervisorId = 1, VacationBalance = 160},
            new Employee{Id = 3, Name = "Eric" ,Lastname="Smits", BSN= 1983821 ,StartDate = new System.DateTime(2008,5,25) ,PositionType = PositionType.Employee, SupervisorId = 1, VacationBalance = 160},
            new Employee{Id = 4, Name = "Amin" ,Lastname="Janssen", BSN= 2452942 ,StartDate = new System.DateTime(2006,2,20), PositionType = PositionType.Employee, SupervisorId = 1, VacationBalance = 160},
            new Employee{Id = 5, Name = "Klaas" ,Lastname="Pieters", BSN= 9367265 ,StartDate = new System.DateTime(2008,5,25), PositionType = PositionType.Employee, SupervisorId = 1, VacationBalance = 160},
            new Employee{Id = 6, Name = "Jasper" ,Lastname="Geulen", BSN= 7439852 ,StartDate = new System.DateTime(2011,7,5), PositionType = PositionType.Employee, SupervisorId = 1, VacationBalance = 160},
            new Employee{Id = 7, Name = "Sarah" ,Lastname="Klaassen", BSN= 2239824 ,StartDate = new System.DateTime(2013,5,4), PositionType = PositionType.Employee, SupervisorId = 1, VacationBalance = 160},
            new Employee{Id = 8, Name = "Hannah" ,Lastname="Mahmoud", BSN= 9836425 ,StartDate = new System.DateTime(2018,5,19), PositionType = PositionType.Employee, SupervisorId = 1, VacationBalance = 160},
            new Employee{Id = 9, Name = "Armand" ,Lastname="Meeuwsen", BSN= 1882563 ,StartDate = new System.DateTime(2008,5,1), PositionType = PositionType.Manager, SupervisorId = 1 , VacationBalance = 160},
            new Employee{Id = 10,Name = "Amir" ,Lastname="Kadour", BSN= 1782463 ,StartDate = new System.DateTime(2019,1,25), PositionType = PositionType.Employee, SupervisorId = 1, VacationBalance = 160},
           };
            modelBuilder.Entity<Employee>().HasData(employees);


            var registers = new Register[]
           {
            new Register{Id = 1, EmployeeId = 3, TypeLeave = TypeLeave.Personal, Note = "Doctor's visit", StartDate = new System.DateTime(2008,9,19), EndDate = new System.DateTime(2008,9,20), IsApproved = false},
            new Register{Id = 2, EmployeeId = 4, TypeLeave = TypeLeave.Personal, Note = "Doctor's visit", StartDate = new System.DateTime(2008,9,19), EndDate = new System.DateTime(2008,9,20), IsApproved = true},
            new Register{Id = 3, EmployeeId = 6, TypeLeave = TypeLeave.Personal, Note = "Doctor's visit", StartDate = new System.DateTime(2008,9,19), EndDate = new System.DateTime(2008,9,20), IsApproved = false},
            new Register{Id = 4, EmployeeId = 8, TypeLeave = TypeLeave.Personal, Note = "Doctor's visit", StartDate = new System.DateTime(2008,9,19), EndDate = new System.DateTime(2008,9,20), IsApproved = true},
            new Register{Id = 5, EmployeeId = 5, TypeLeave = TypeLeave.Personal, Note = "Doctor's visit", StartDate = new System.DateTime(2008,9,19), EndDate = new System.DateTime(2008,9,20), IsApproved = true},
            new Register{Id = 6, EmployeeId = 1, TypeLeave = TypeLeave.Personal, Note = "Doctor's visit", StartDate = new System.DateTime(2008,9,19), EndDate = new System.DateTime(2008,9,20), IsApproved = false}
           };
            modelBuilder.Entity<Register>().HasData(registers);


            var users = new User[]
          {
            new User{Id = 1, Username = "S.Leeuwen", Password = BCrypt.Net.BCrypt.HashPassword("Nijmegen-024"), Role = RoleType.Admin, EmployeeId = 1},
            new User{Id = 2, Username = "J.Anders", Password = BCrypt.Net.BCrypt.HashPassword("Nijmegen-024"), Role = RoleType.User, EmployeeId = 2},
            new User{Id = 3, Username = "E.Smits", Password = BCrypt.Net.BCrypt.HashPassword("Nijmegen-024"), Role = RoleType.User, EmployeeId = 3},
            new User{Id = 4, Username = "A.Janssen", Password = BCrypt.Net.BCrypt.HashPassword("Nijmegen-024"), Role = RoleType.User,EmployeeId = 4 },
            new User{Id = 5, Username = "K.Pieters", Password = BCrypt.Net.BCrypt.HashPassword("Nijmegen-024"), Role = RoleType.User , EmployeeId = 5},
            new User{Id = 6, Username = "J.Geulen", Password = BCrypt.Net.BCrypt.HashPassword("Nijmegen-024"), Role = RoleType.User, EmployeeId = 6},
            new User{Id = 7, Username = "S.Klaassen", Password = BCrypt.Net.BCrypt.HashPassword("Nijmegen-024"), Role = RoleType.User, EmployeeId =7},
            new User{Id = 8, Username = "H.Mahmoud", Password = BCrypt.Net.BCrypt.HashPassword("Nijmegen-024"), Role = RoleType.User, EmployeeId = 8},
            new User{Id = 9, Username = "A.Meeuwsen", Password = BCrypt.Net.BCrypt.HashPassword("Nijmegen-024"), Role = RoleType.User, EmployeeId = 9},
            new User{Id = 10,Username = "A.Kadour", Password = BCrypt.Net.BCrypt.HashPassword("Nijmegen-024"), Role = RoleType.User, EmployeeId = 10},
          };
            modelBuilder.Entity<User>().HasData(users);

            //modelBuilder.Entity<Employee>().HasOne(x => x.Supervisor).WithMany(x => x.Employees).HasForeignKey(x => x.Supervisor);
        }
    }
}
