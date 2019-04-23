using Microsoft.EntityFrameworkCore.Migrations;

namespace NewWorkersDB.Migrations
{
    public partial class addAgeToWorker : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Worker",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Worker");
        }
    }
}
