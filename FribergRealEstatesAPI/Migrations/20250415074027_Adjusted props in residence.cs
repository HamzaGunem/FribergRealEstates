using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FribergRealEstatesAPI.Migrations
{
    /// <inheritdoc />
    public partial class Adjustedpropsinresidence : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "beArea",
                table: "Residences",
                newName: "Area");

            migrationBuilder.AddColumn<int>(
                name: "Floors",
                table: "Residences",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Floors",
                table: "Residences");

            migrationBuilder.RenameColumn(
                name: "Area",
                table: "Residences",
                newName: "beArea");
        }
    }
}
