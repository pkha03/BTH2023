using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BTH112.Migrations
{
    /// <inheritdoc />
    public partial class Sinhvien : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lophoc",
                columns: table => new
                {
                    malop = table.Column<string>(type: "TEXT", nullable: false),
                    tenlop = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lophoc", x => x.malop);
                });

            migrationBuilder.CreateTable(
                name: "Sinhvien",
                columns: table => new
                {
                    tensv = table.Column<string>(type: "TEXT", nullable: false),
                    masv = table.Column<string>(type: "TEXT", nullable: false),
                    tenlop = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sinhvien", x => x.tensv);
                    table.ForeignKey(
                        name: "FK_Sinhvien_Lophoc_tenlop",
                        column: x => x.tenlop,
                        principalTable: "Lophoc",
                        principalColumn: "malop",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sinhvien_tenlop",
                table: "Sinhvien",
                column: "tenlop");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sinhvien");

            migrationBuilder.DropTable(
                name: "Lophoc");
        }
    }
}
