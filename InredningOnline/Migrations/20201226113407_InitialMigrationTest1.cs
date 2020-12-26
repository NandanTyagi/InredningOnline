using Microsoft.EntityFrameworkCore.Migrations;

namespace InredningOnline.Migrations
{
    public partial class InitialMigrationTest1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "ProjectId",
                value: 4);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "ProjectId",
                value: 3);
        }
    }
}
