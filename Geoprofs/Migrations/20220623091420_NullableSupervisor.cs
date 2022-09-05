using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Geoprofs.Migrations
{
    public partial class NullableSupervisor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Lastname = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BSN = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    PositionType = table.Column<int>(type: "int", nullable: false),
                    SupervisorId = table.Column<int>(type: "int", nullable: true),
                    VacationBalance = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Employees_SupervisorId",
                        column: x => x.SupervisorId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Registers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    TypeLeave = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StartDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsApproved = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Registers_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Role = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "BSN", "Lastname", "Name", "PositionType", "StartDate", "SupervisorId", "VacationBalance" },
                values: new object[] { 1, 2595714, "Leeuwen", "Sandra", 0, new DateTime(2008, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 160 });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "BSN", "Lastname", "Name", "PositionType", "StartDate", "SupervisorId", "VacationBalance" },
                values: new object[,]
                {
                    { 2, 2375648, "Anders", "Jarno", 1, new DateTime(2001, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 160 },
                    { 3, 1983821, "Smits", "Eric", 0, new DateTime(2008, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 160 },
                    { 4, 2452942, "Janssen", "Amin", 0, new DateTime(2006, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 160 },
                    { 5, 9367265, "Pieters", "Klaas", 0, new DateTime(2008, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 160 },
                    { 6, 7439852, "Geulen", "Jasper", 0, new DateTime(2011, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 160 },
                    { 7, 2239824, "Klaassen", "Sarah", 0, new DateTime(2013, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 160 },
                    { 8, 9836425, "Mahmoud", "Hannah", 0, new DateTime(2018, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 160 },
                    { 9, 1882563, "Meeuwsen", "Armand", 1, new DateTime(2008, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 160 },
                    { 10, 1782463, "Kadour", "Amir", 0, new DateTime(2019, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 160 }
                });

            migrationBuilder.InsertData(
                table: "Registers",
                columns: new[] { "Id", "EmployeeId", "EndDate", "IsApproved", "Note", "StartDate", "TypeLeave" },
                values: new object[] { 6, 1, new DateTime(2008, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Doctor's visit", new DateTime(2008, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "EmployeeId", "Password", "Role", "Username" },
                values: new object[] { 1, 1, "$2a$11$ijjLdxI6S0UBpiaHaokm7.1pvemzmge4Fw9.4vtN/QvQPXCYy9m8C", 1, "S.Leeuwen" });

            migrationBuilder.InsertData(
                table: "Registers",
                columns: new[] { "Id", "EmployeeId", "EndDate", "IsApproved", "Note", "StartDate", "TypeLeave" },
                values: new object[,]
                {
                    { 1, 3, new DateTime(2008, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Doctor's visit", new DateTime(2008, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 2, 4, new DateTime(2008, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Doctor's visit", new DateTime(2008, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 5, 5, new DateTime(2008, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Doctor's visit", new DateTime(2008, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 3, 6, new DateTime(2008, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Doctor's visit", new DateTime(2008, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 4, 8, new DateTime(2008, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Doctor's visit", new DateTime(2008, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "EmployeeId", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { 2, 2, "$2a$11$QDN1txY6EGnzW0pwUk7wXOtcx6wS0ddiEe8qNSdm5m5S5CC9PRHBq", 3, "J.Anders" },
                    { 3, 3, "$2a$11$L3pqR5iEk85RNiJ4Dhe8gur/Eb85UYOK2QUdRfM3R8GRv31Lcgaxu", 3, "E.Smits" },
                    { 4, 4, "$2a$11$nqhwKl.Dnmb1D2jL6/EGK.Q7391qDBHd/S4vrJeV.0uMXhbkO3Ex6", 2, "A.Janssen" },
                    { 5, 5, "$2a$11$KEUx86aOS4UdrAkHye7uze/NHV4.ELTIgyF7DxLyh8YzbWd2crPw.", 3, "K.Pieters" },
                    { 6, 6, "$2a$11$ShVcvSuIRWip51U5ir0CTejSRqoZmSy155aceBR3gqaCJ51uQ/ZLS", 3, "J.Geulen" },
                    { 7, 7, "$2a$11$j5CpaTtDUUIYPfE0uigd0.Otr28Ug4YFjGGu3ljI56JO2JP6O53wa", 2, "S.Klaassen" },
                    { 8, 8, "$2a$11$9VF/u2DRD1riZauFjoJIoO5P8tz7M3tKLQ0NXu1hFvHtkrlM2hPpO", 3, "H.Mahmoud" },
                    { 9, 9, "$2a$11$BkyNjkM.4YdWco1/njYYF.b27VJJ6bUR2UxtqlJvdQiK7wdeC7I6m", 3, "A.Meeuwsen" },
                    { 10, 10, "$2a$11$MMYw/y5V4Eas.e6lFON4s.85Egnds1mcQ24SxtUs1zv/nDGlHR2HK", 3, "A.Kadour" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_SupervisorId",
                table: "Employees",
                column: "SupervisorId");

            migrationBuilder.CreateIndex(
                name: "IX_Registers_EmployeeId",
                table: "Registers",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_EmployeeId",
                table: "Users",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Registers");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
