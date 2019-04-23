using Microsoft.EntityFrameworkCore.Migrations;

namespace NewWorkersDB.Migrations
{
    public partial class addHasChildrenToWorker : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "HasChildren",
                table: "Worker",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasChildren",
                table: "Worker");
        }
    }
}
