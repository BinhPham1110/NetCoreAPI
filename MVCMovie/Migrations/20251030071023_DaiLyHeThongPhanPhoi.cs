using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCMovie.Migrations
{
    /// <inheritdoc />
    public partial class DaiLyHeThongPhanPhoi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HeThongPhanPhois",
                columns: table => new
                {
                    MaHTPP = table.Column<string>(type: "TEXT", nullable: false),
                    TenHTPP = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    DiaChi = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    DienThoai = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeThongPhanPhois", x => x.MaHTPP);
                });

            migrationBuilder.CreateTable(
                name: "DaiLys",
                columns: table => new
                {
                    MaDaiLy = table.Column<string>(type: "TEXT", nullable: false),
                    TenDaiLy = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    DiaChi = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    NguoiDaiDien = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    DienThoai = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    MaHTPP = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DaiLys", x => x.MaDaiLy);
                    table.ForeignKey(
                        name: "FK_DaiLys_HeThongPhanPhois_MaHTPP",
                        column: x => x.MaHTPP,
                        principalTable: "HeThongPhanPhois",
                        principalColumn: "MaHTPP",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DaiLys_MaHTPP",
                table: "DaiLys",
                column: "MaHTPP");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DaiLys");

            migrationBuilder.DropTable(
                name: "HeThongPhanPhois");
        }
    }
}
