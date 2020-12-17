using Microsoft.EntityFrameworkCore.Migrations;

namespace IntelligentGrowthSolutions.Marketplace.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    product_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    Price = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.product_id);
                });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "product_id", "Name", "Price" },
                values: new object[] { 1, "Lavender heart", "9.25" });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "product_id", "Name", "Price" },
                values: new object[] { 2, "Personalised cufflinks", "45.00" });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "product_id", "Name", "Price" },
                values: new object[] { 3, "Kids T-shirt", "19.95" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "products");
        }
    }
}
