using Microsoft.EntityFrameworkCore.Migrations;

namespace InredningOnline.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Designers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Designers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DesignerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_Designers_DesignerId",
                        column: x => x.DesignerId,
                        principalTable: "Designers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Materials_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Designers",
                columns: new[] { "Id", "Email", "IsAdmin", "Name" },
                values: new object[] { 1, "me@nandan.com", true, "Nandan" });

            migrationBuilder.InsertData(
                table: "Designers",
                columns: new[] { "Id", "Email", "IsAdmin", "Name" },
                values: new object[] { 2, "me@hadis.com", false, "Hadis" });

            migrationBuilder.InsertData(
                table: "Designers",
                columns: new[] { "Id", "Email", "IsAdmin", "Name" },
                values: new object[] { 3, "me@ali.com", false, "Ali" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Name", "DesignerId" },
                values: new object[,]
                {
                    { 1, "Project1", 1 },
                    { 2, "Project2", 2 },
                    { 4, "Project4", 2 },
                    { 3, "Project3", 3 }
                });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "Id", "Amount", "Details", "Name", "Price", "ProjectId" },
                values: new object[,]
                {
                    { 1, 1, "N/A", "Material1", 45m, 1 },
                    { 2, 1, "N/A", "Material2", 98m, 2 },
                    { 4, 2, "N/A", "Material4", 77m, 2 },
                    { 5, 10, "N/A", "Material5", 105m, 2 },
                    { 6, 1, "N/A", "Material6", 12m, 2 },
                    { 3, 1, "N/A", "Material3", 67000m, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Materials_ProjectId",
                table: "Materials",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_DesignerId",
                table: "Projects",
                column: "DesignerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Designers");
        }
    }
}
