using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreFoody.DataAccessLayer.Migrations
{
    public partial class AddedImageUrlToFeature : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Features",
                type: "nvarchar(200)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Features");
        }
    }
}
