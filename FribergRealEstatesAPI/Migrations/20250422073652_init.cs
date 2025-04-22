using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FribergRealEstatesAPI.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Communs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Communs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommunId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Communs_CommunId",
                        column: x => x.CommunId,
                        principalTable: "Communs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Agencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agencies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Agencies_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Residences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Area = table.Column<int>(type: "int", nullable: false),
                    BiArea = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rooms = table.Column<int>(type: "int", nullable: false),
                    Floors = table.Column<int>(type: "int", nullable: true),
                    FloorRows = table.Column<int>(type: "int", nullable: false),
                    MonthlyFee = table.Column<double>(type: "float", nullable: true),
                    OperatingCost = table.Column<double>(type: "float", nullable: false),
                    BuildYear = table.Column<int>(type: "int", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParkingSlotNumber = table.Column<int>(type: "int", nullable: true),
                    Facilities = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    CommunId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Residences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Residences_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Residences_Communs_CommunId",
                        column: x => x.CommunId,
                        principalTable: "Communs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Realtors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgencyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Realtors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Realtors_Agencies_AgencyId",
                        column: x => x.AgencyId,
                        principalTable: "Agencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Adverts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Sold = table.Column<bool>(type: "bit", nullable: false),
                    CurrentPrice = table.Column<double>(type: "float", nullable: false),
                    RealtorId = table.Column<int>(type: "int", nullable: false),
                    ResidenceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adverts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Adverts_Realtors_RealtorId",
                        column: x => x.RealtorId,
                        principalTable: "Realtors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Adverts_Residences_ResidenceId",
                        column: x => x.ResidenceId,
                        principalTable: "Residences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CommunId",
                table: "Addresses",
                column: "CommunId");

            migrationBuilder.CreateIndex(
                name: "IX_Adverts_RealtorId",
                table: "Adverts",
                column: "RealtorId");

            migrationBuilder.CreateIndex(
                name: "IX_Adverts_ResidenceId",
                table: "Adverts",
                column: "ResidenceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Agencies_AddressId",
                table: "Agencies",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Realtors_AgencyId",
                table: "Realtors",
                column: "AgencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Residences_AddressId",
                table: "Residences",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Residences_CommunId",
                table: "Residences",
                column: "CommunId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adverts");

            migrationBuilder.DropTable(
                name: "Realtors");

            migrationBuilder.DropTable(
                name: "Residences");

            migrationBuilder.DropTable(
                name: "Agencies");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Communs");
        }
    }
}
