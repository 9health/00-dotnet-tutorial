using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _201_samples.Migrations
{
    public partial class _02_SecondMealAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MealVerFMealId",
                table: "Foods",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    MealId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MealName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.MealId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Foods_MealVerFMealId",
                table: "Foods",
                column: "MealVerFMealId");

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_Meals_MealVerFMealId",
                table: "Foods",
                column: "MealVerFMealId",
                principalTable: "Meals",
                principalColumn: "MealId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Foods_Meals_MealVerFMealId",
                table: "Foods");

            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.DropIndex(
                name: "IX_Foods_MealVerFMealId",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "MealVerFMealId",
                table: "Foods");
        }
    }
}
