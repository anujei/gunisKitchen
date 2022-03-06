using Microsoft.EntityFrameworkCore.Migrations;

namespace gunisKitchen.Migrations
{
    public partial class changecategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "category",
                table: "categorys",
                newName: "categoryName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "categoryName",
                table: "categorys",
                newName: "category");
        }
    }
}
