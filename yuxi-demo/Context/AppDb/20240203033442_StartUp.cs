using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace yuxi_demo.Context.AppDb
{
    /// <inheritdoc />
    public partial class StartUp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OpenHour = table.Column<TimeOnly>(type: "time", nullable: false),
                    CloseHour = table.Column<TimeOnly>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "CloseHour", "Description", "OpenHour" },
                values: new object[,]
                {
                    { new Guid("23c37f80-0285-4f39-b0f7-ad83750e11fa"), new TimeOnly(10, 0, 0), "Barber shop", new TimeOnly(13, 0, 0) },
                    { new Guid("3de853c9-7cc7-4ef4-a606-4c922c8d7425"), new TimeOnly(10, 0, 0), "Restaurant", new TimeOnly(13, 0, 0) },
                    { new Guid("8e35aea7-1fa2-4818-9fb7-35cb4707fd79"), new TimeOnly(10, 0, 0), "Mall", new TimeOnly(12, 0, 0) },
                    { new Guid("9df119e0-0874-4a33-bb25-ed87aa6619fd"), new TimeOnly(10, 0, 0), "Pharmacy,", new TimeOnly(13, 0, 0) },
                    { new Guid("9efb9793-8591-425d-a19d-173d190877bf"), new TimeOnly(10, 0, 0), "Park", new TimeOnly(12, 0, 0) },
                    { new Guid("c097db03-660a-4168-b2b6-06e086919d46"), new TimeOnly(10, 0, 0), "Cinema", new TimeOnly(12, 0, 0) },
                    { new Guid("e951bb42-73e3-473d-9756-5d0597a833ed"), new TimeOnly(10, 0, 0), "Bakery", new TimeOnly(12, 0, 0) },
                    { new Guid("eeb27d91-eaf8-4632-90ab-6ba82e2b5039"), new TimeOnly(10, 0, 0), "Bank", new TimeOnly(13, 0, 0) },
                    { new Guid("f81f69c0-8678-4914-95a8-b0d35c4b6199"), new TimeOnly(10, 0, 0), "Supermarket,", new TimeOnly(12, 0, 0) },
                    { new Guid("fa2e0e0e-c06f-409f-a0f5-19c5b6b56f8d"), new TimeOnly(10, 0, 0), "Candy Store", new TimeOnly(13, 0, 0) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Locations");
        }
    }
}
