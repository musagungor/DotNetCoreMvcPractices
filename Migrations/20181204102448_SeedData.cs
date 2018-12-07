using Microsoft.EntityFrameworkCore.Migrations;

namespace DotNetCoreMvcPractices.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into brands(Name) values ('Mercedes')");
            migrationBuilder.Sql("insert into brands(Name) values ('Anadol')");
            migrationBuilder.Sql("insert into brands(Name) values ('Renault')");
            migrationBuilder.Sql("insert into brands(Name) values ('Suziki')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete  brands where name = 'Mercedes'");
            migrationBuilder.Sql("delete  brands where name = 'Anadol'");
            migrationBuilder.Sql("delete  brands where name = 'Renault'");
            migrationBuilder.Sql("delete  brands where name = 'Suziki'");
        }
    }
}
