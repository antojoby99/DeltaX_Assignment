using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Add_Edit_Delete_Movie_API.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieName = table.Column<string>(nullable: false),
                    plot = table.Column<string>(nullable: false),
                    DateofRelease = table.Column<DateTime>(nullable: false),
                    Producer = table.Column<string>(nullable: true),
                    Actor = table.Column<string>(nullable: true),
                    poster = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieName);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
