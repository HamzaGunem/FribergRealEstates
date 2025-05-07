using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FribergRealEstatesAPI.Migrations
{
    /// <inheritdoc />
    public partial class addedadmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Realtors_ApiUserId",
                table: "Realtors");

            migrationBuilder.AlterColumn<string>(
                name: "ApiUserId",
                table: "Realtors",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApiUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Admins_AspNetUsers_ApiUserId",
                        column: x => x.ApiUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Realtors_ApiUserId",
                table: "Realtors",
                column: "ApiUserId",
                unique: true,
                filter: "[ApiUserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Admins_ApiUserId",
                table: "Admins",
                column: "ApiUserId",
                unique: true,
                filter: "[ApiUserId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropIndex(
                name: "IX_Realtors_ApiUserId",
                table: "Realtors");

            migrationBuilder.AlterColumn<string>(
                name: "ApiUserId",
                table: "Realtors",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Realtors_ApiUserId",
                table: "Realtors",
                column: "ApiUserId",
                unique: true);
        }
    }
}
