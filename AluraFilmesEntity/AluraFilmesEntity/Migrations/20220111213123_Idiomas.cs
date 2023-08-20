using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AluraFilmesEntity.Migrations
{
    public partial class Idiomas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "language_id",
                table: "films",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<byte>(
                name: "original_language_id",
                table: "films",
                type: "tinyint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "films_actors",
                columns: table => new
                {
                    actor_id = table.Column<int>(type: "int", nullable: false),
                    film_id = table.Column<int>(type: "int", nullable: false),
                    last_update = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_films_actors", x => new { x.actor_id, x.film_id });
                    table.ForeignKey(
                        name: "FK_films_actors_actors_actor_id",
                        column: x => x.actor_id,
                        principalTable: "actors",
                        principalColumn: "actor_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_films_actors_films_film_id",
                        column: x => x.film_id,
                        principalTable: "films",
                        principalColumn: "film_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "languages",
                columns: table => new
                {
                    language_id = table.Column<byte>(type: "tinyint", nullable: false),
                    name = table.Column<string>(type: "char(20)", nullable: false),
                    last_update = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_languages", x => x.language_id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_films_language_id",
                table: "films",
                column: "language_id");

            migrationBuilder.CreateIndex(
                name: "IX_films_original_language_id",
                table: "films",
                column: "original_language_id");

            migrationBuilder.CreateIndex(
                name: "IX_films_actors_film_id",
                table: "films_actors",
                column: "film_id");

            migrationBuilder.AddForeignKey(
                name: "FK_films_languages_language_id",
                table: "films",
                column: "language_id",
                principalTable: "languages",
                principalColumn: "language_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_films_languages_original_language_id",
                table: "films",
                column: "original_language_id",
                principalTable: "languages",
                principalColumn: "language_id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_films_languages_language_id",
                table: "films");

            migrationBuilder.DropForeignKey(
                name: "FK_films_languages_original_language_id",
                table: "films");

            migrationBuilder.DropTable(
                name: "films_actors");

            migrationBuilder.DropTable(
                name: "languages");

            migrationBuilder.DropIndex(
                name: "IX_films_language_id",
                table: "films");

            migrationBuilder.DropIndex(
                name: "IX_films_original_language_id",
                table: "films");

            migrationBuilder.DropColumn(
                name: "language_id",
                table: "films");

            migrationBuilder.DropColumn(
                name: "original_language_id",
                table: "films");
        }
    }
}
