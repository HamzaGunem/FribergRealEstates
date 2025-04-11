using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FribergRealEstatesAPI.Migrations
{
    /// <inheritdoc />
    public partial class Changepropsnametorightnames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Steet",
                table: "Address",
                newName: "Street");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Street",
                table: "Address",
                newName: "Steet");
        }
    }
}
