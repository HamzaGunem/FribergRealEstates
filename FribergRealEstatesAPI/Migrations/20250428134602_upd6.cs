using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FribergRealEstatesAPI.Migrations
{
    /// <inheritdoc />
    public partial class upd6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "65161035-f041-4293-aabf-557b9bafc89c", null, "SuperAdmin", "SuperAdmin" },
                    { "896dfa0e-3035-4dd1-9f6b-061896a10140", null, "Admin", "Admin" },
                    { "8dbf5e67-e5dc-4fa5-a41b-3be035b70d2c", null, "User", "User" },
                    { "d8a759ea-8753-4e78-b8f0-1130af4c0691", null, "Realtor", "Realtor" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f866bbe6-a717-4958-9134-9f30a8113360", 0, "870a8806-cfa2-4450-864b-c9c0f1facf99", "admin@api.com", true, "System", "Admin", false, null, "ADMIN@API.COM", "ADMIN@API.COM", "AQAAAAIAAYagAAAAEDAYbZGG974mrgZV0SKx9Yep2XcSiA1TCmRB/t4iWd7gfn+ocEhq+e0gijDomgCxhg==", null, false, "60a81f0e-d836-4f62-a55b-3e37caad2293", false, "admin@api.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "896dfa0e-3035-4dd1-9f6b-061896a10140", "f866bbe6-a717-4958-9134-9f30a8113360" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65161035-f041-4293-aabf-557b9bafc89c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8dbf5e67-e5dc-4fa5-a41b-3be035b70d2c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8a759ea-8753-4e78-b8f0-1130af4c0691");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "896dfa0e-3035-4dd1-9f6b-061896a10140", "f866bbe6-a717-4958-9134-9f30a8113360" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "896dfa0e-3035-4dd1-9f6b-061896a10140");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f866bbe6-a717-4958-9134-9f30a8113360");
        }
    }
}
