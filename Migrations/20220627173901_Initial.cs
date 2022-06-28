using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1RainerStropek.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "gameGenres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gameGenres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "games",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    GameGenreId = table.Column<int>(type: "int", nullable: true),
                    personalRating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_games", x => x.ID);
                    table.ForeignKey(
                        name: "FK_games_gameGenres_GameGenreId",
                        column: x => x.GameGenreId,
                        principalTable: "gameGenres",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_games_GameGenreId",
                table: "games",
                column: "GameGenreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "games");

            migrationBuilder.DropTable(
                name: "gameGenres");
        }
    }
}
