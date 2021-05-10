using Microsoft.EntityFrameworkCore.Migrations;

namespace eMovieStore.Migrations
{
    public partial class InitMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Author = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    YearOfProduction = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Author", "Genre", "PhotoPath", "Title", "YearOfProduction" },
                values: new object[] { 1, "Martin Scorsese", "Thriller", null, "Wyspa tajemnic", 2010 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Author", "Genre", "PhotoPath", "Title", "YearOfProduction" },
                values: new object[] { 2, "Frank Darabont", "Dramat", null, "Skazani na Shawshank", 1994 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
