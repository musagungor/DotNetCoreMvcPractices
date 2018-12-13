using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DotNetCoreMvcPractices.Migrations
{
    public partial class ProductDateFieldsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
			var dateNow = DateTime.Now;
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Products",
                nullable: false,
                defaultValue: new DateTime(dateNow.Year,dateNow.Month, dateNow.Day, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "MarketDate",
                table: "Products",
                nullable: false,
                defaultValue: new DateTime(dateNow.AddDays(2).Year, dateNow.AddDays(2).Month, dateNow.AddDays(2).Day, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "MarketDate",
                table: "Products");
        }
    }
}
