using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _201_samples.Migrations
{
    public partial class _01_FirstFoodModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    FoodId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FoodTime = table.Column<int>(type: "INTEGER", nullable: false),
                    FoodSteps = table.Column<int>(type: "INTEGER", nullable: false),
                    FoodViews = table.Column<int>(type: "INTEGER", nullable: false),
                    IngredientNum = table.Column<int>(type: "INTEGER", nullable: false),
                    FoodName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.FoodId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Foods");
        }
    }
}
