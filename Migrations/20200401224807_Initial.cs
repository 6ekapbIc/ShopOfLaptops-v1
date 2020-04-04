using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    categoryName = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Laptop",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true),
                    shortDescription = table.Column<string>(nullable: true),
                    img = table.Column<string>(nullable: true),
                    price = table.Column<long>(nullable: false),
                    available = table.Column<int>(nullable: false),
                    modelOfProcessor = table.Column<string>(nullable: true),
                    frequencyOfProcessor = table.Column<double>(nullable: false),
                    diagonal = table.Column<double>(nullable: false),
                    typeOfDisplay = table.Column<string>(nullable: true),
                    frequencyOfDisplay = table.Column<int>(nullable: false),
                    ram = table.Column<int>(nullable: false),
                    slotsOfRam = table.Column<int>(nullable: false),
                    modelOfVideoCard = table.Column<string>(nullable: true),
                    volumeOfVideoCard = table.Column<string>(nullable: true),
                    typeOfMemory = table.Column<string>(nullable: true),
                    volumeOfMemory = table.Column<string>(nullable: true),
                    backlight = table.Column<bool>(nullable: false),
                    camera = table.Column<bool>(nullable: false),
                    weight = table.Column<double>(nullable: false),
                    os = table.Column<string>(nullable: true),
                    categoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laptop", x => x.id);
                    table.ForeignKey(
                        name: "FK_Laptop_Category_categoryId",
                        column: x => x.categoryId,
                        principalTable: "Category",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Laptop_categoryId",
                table: "Laptop",
                column: "categoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Laptop");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
