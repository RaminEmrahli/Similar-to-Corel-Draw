using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Datalar.Migrations
{
    public partial class telebetableyaratma : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Telebeler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SiniflerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telebeler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Telebeler_Sinifler_SiniflerId",
                        column: x => x.SiniflerId,
                        principalTable: "Sinifler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Telebeler_SiniflerId",
                table: "Telebeler",
                column: "SiniflerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Telebeler");
        }
    }
}
