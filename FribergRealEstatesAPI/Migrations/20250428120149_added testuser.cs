using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FribergRealEstatesAPI.Migrations
{
    /// <inheritdoc />
    public partial class addedtestuser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "65161035-f041-4293-aabf-557b9bafc89c", null, null, null },
                    { "896dfa0e-3035-4dd1-9f6b-061896a10140", null, null, null },
                    { "8dbf5e67-e5dc-4fa5-a41b-3be035b70d2c", null, null, null },
                    { "d8a759ea-8753-4e78-b8f0-1130af4c0691", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f866bbe6-a717-4958-9134-9f30a8113360", 0, "7812e9ef-847b-411e-9bb4-db1d11802407", "ApiUser", "admin@api.com", true, "System", "Admin", false, null, "ADMIN@API.COM", "ADMIN@API.COM", "AQAAAAIAAYagAAAAEPv2O6B4uIJY+6+AgZZ8JaUEKjaH8rcH4ph1nSJWSooZAuNOH+xAGbruuoN1tIHiUA==", null, false, "c03aa14f-d575-4b03-aece-d76714c4ba01", false, "admin@api.com" });

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

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");
        }
    }
}
