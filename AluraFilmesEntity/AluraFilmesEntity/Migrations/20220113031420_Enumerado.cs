using Microsoft.EntityFrameworkCore.Migrations;

namespace AluraFilmesEntity.Migrations
{
    public partial class Enumerado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "rating",
                table: "films",
                type: "varchar(10)",
                nullable: true);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_actors_first_name_last_name",
                table: "actors",
                columns: new[] { "first_name", "last_name" });

            migrationBuilder.CreateIndex(
                name: "idx_actor_last_name",
                table: "actors",
                column: "last_name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_actors_first_name_last_name",
                table: "actors");

            migrationBuilder.DropIndex(
                name: "idx_actor_last_name",
                table: "actors");

            migrationBuilder.DropColumn(
                name: "rating",
                table: "films");
        }
    }
}
