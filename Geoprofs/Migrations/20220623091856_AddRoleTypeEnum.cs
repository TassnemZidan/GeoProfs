using Microsoft.EntityFrameworkCore.Migrations;

namespace Geoprofs.Migrations
{
    public partial class AddRoleTypeEnum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Password", "Role" },
                values: new object[] { "$2a$11$MSrjENQsXK27CSV0PbWXJ.my2RkK6GiMh8QqN6QujazgcpxPJAZVK", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Password", "Role" },
                values: new object[] { "$2a$11$nR99kkQk5qKkskPxu1o/buUHwhz7xQp8bnwN9XMqZMyBLp4Y0fKB2", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Password", "Role" },
                values: new object[] { "$2a$11$6aVCuFfTf.2siR8f7fnpoegVKBl/230YxwDoRilKnMBExU5.ylhsu", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Password", "Role" },
                values: new object[] { "$2a$11$JWahAUpVacVhqW1u8dcJxeFUoHTnNa8J.vip7BS15z9avYJoz4JlW", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Password", "Role" },
                values: new object[] { "$2a$11$WMl3QF1HQjazox.Dz/hcCeFaV0zor2ka94n4jITPfQDfi2v4HcS7S", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Password", "Role" },
                values: new object[] { "$2a$11$fj6NF9fhsuPE3kwZ8Zlgq.xTQqNwUAjq1YQjX24Y3H5KQro/f1gPy", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Password", "Role" },
                values: new object[] { "$2a$11$W85CtTWbxC55tzRp4qKEhOZNFlW9NXDvm9LUnX0sPXkPEumpZsWy.", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Password", "Role" },
                values: new object[] { "$2a$11$9DI8CflhrrxWjCwxmkn2neOSWixb5ZMhhpyTZ5QpdJJByT6P20ele", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Password", "Role" },
                values: new object[] { "$2a$11$Nnlv/wKlRQ7SBj3BIHNtgOvtMW2XRSZH3r4aDTkqI4m7PNvpHoqFG", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Password", "Role" },
                values: new object[] { "$2a$11$dlguPSNYppexMQZBY4/WKOFNQRT7Wc1yoV0hCzx/A643JrPqeH3NS", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Password", "Role" },
                values: new object[] { "$2a$11$ijjLdxI6S0UBpiaHaokm7.1pvemzmge4Fw9.4vtN/QvQPXCYy9m8C", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Password", "Role" },
                values: new object[] { "$2a$11$QDN1txY6EGnzW0pwUk7wXOtcx6wS0ddiEe8qNSdm5m5S5CC9PRHBq", 3 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Password", "Role" },
                values: new object[] { "$2a$11$L3pqR5iEk85RNiJ4Dhe8gur/Eb85UYOK2QUdRfM3R8GRv31Lcgaxu", 3 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Password", "Role" },
                values: new object[] { "$2a$11$nqhwKl.Dnmb1D2jL6/EGK.Q7391qDBHd/S4vrJeV.0uMXhbkO3Ex6", 2 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Password", "Role" },
                values: new object[] { "$2a$11$KEUx86aOS4UdrAkHye7uze/NHV4.ELTIgyF7DxLyh8YzbWd2crPw.", 3 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Password", "Role" },
                values: new object[] { "$2a$11$ShVcvSuIRWip51U5ir0CTejSRqoZmSy155aceBR3gqaCJ51uQ/ZLS", 3 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Password", "Role" },
                values: new object[] { "$2a$11$j5CpaTtDUUIYPfE0uigd0.Otr28Ug4YFjGGu3ljI56JO2JP6O53wa", 2 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Password", "Role" },
                values: new object[] { "$2a$11$9VF/u2DRD1riZauFjoJIoO5P8tz7M3tKLQ0NXu1hFvHtkrlM2hPpO", 3 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Password", "Role" },
                values: new object[] { "$2a$11$BkyNjkM.4YdWco1/njYYF.b27VJJ6bUR2UxtqlJvdQiK7wdeC7I6m", 3 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Password", "Role" },
                values: new object[] { "$2a$11$MMYw/y5V4Eas.e6lFON4s.85Egnds1mcQ24SxtUs1zv/nDGlHR2HK", 3 });
        }
    }
}
