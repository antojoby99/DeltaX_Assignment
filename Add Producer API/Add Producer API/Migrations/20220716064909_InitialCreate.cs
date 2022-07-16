using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Add_Producer_API.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Producer",
                columns: table => new
                {
                    Producer_Name = table.Column<string>(nullable: false),
                    Bio = table.Column<string>(nullable: true),
                    Date_of_birth = table.Column<DateTime>(nullable: false),
                    Comapny = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producer", x => x.Producer_Name);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Producer");
        }
    }
}
