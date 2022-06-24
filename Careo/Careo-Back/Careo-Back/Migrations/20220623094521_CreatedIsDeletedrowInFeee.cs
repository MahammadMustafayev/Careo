using Microsoft.EntityFrameworkCore.Migrations;

namespace Careo_Back.Migrations
{
    public partial class CreatedIsDeletedrowInFeee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "FeedBacks",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "FeedBacks");
        }
    }
}
