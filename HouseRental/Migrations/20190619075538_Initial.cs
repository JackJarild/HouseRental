using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HouseRental.Api.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "House",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HouseType = table.Column<int>(nullable: false),
                    BaseDayFee = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_House", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reservation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HouseId = table.Column<int>(nullable: false),
                    FromDate = table.Column<DateTime>(nullable: false),
                    ToDate = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    Price = table.Column<double>(nullable: false),
                    HouseId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservation_House_HouseId",
                        column: x => x.HouseId,
                        principalTable: "House",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservation_House_HouseId1",
                        column: x => x.HouseId1,
                        principalTable: "House",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "House",
                columns: new[] { "Id", "BaseDayFee", "HouseType" },
                values: new object[,]
                {
                    { 1, 5.0, 2 },
                    { 2, 112.3, 4 },
                    { 3, 33.0, 2 },
                    { 4, 50.0, 4 },
                    { 5, 25.5, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_HouseId",
                table: "Reservation",
                column: "HouseId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_HouseId1",
                table: "Reservation",
                column: "HouseId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservation");

            migrationBuilder.DropTable(
                name: "House");
        }
    }
}
