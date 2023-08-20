using Microsoft.EntityFrameworkCore.Migrations;

namespace AluraFilmesEntity.Migrations
{
  public partial class ConstraintCheck : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      var sql = @"ALTER TABLE [dbo].[films] 
                  ADD CONSTRAINT [check_rating] CHECK 
                    (
                      [rating] = 'NC-17' OR
                      [rating] = 'R' OR
                      [rating] = 'PG-13' OR
                      [rating] = 'PG' OR
                      [rating] = 'G'
                    )";
      migrationBuilder.Sql(sql);
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
      var sql = @"ALTER TABLE [dbo].[films] DROP CONSTRAINT [check_rating]";
      migrationBuilder.Sql(sql);
    }
  }
}
