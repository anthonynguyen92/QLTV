using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityDb.Migrations
{
    public partial class initialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PhieuMuonSach",
                columns: table => new
                {
                    MaPhieuMuon = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NgayMuon = table.Column<string>(nullable: true),
                    NgayTra = table.Column<string>(nullable: true),
                    MaDocGia = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuMuonSach", x => x.MaPhieuMuon);
                });

            migrationBuilder.CreateTable(
                name: "Sach",
                columns: table => new
                {
                    MaSach = table.Column<string>(nullable: false),
                    TenSach = table.Column<string>(nullable: true),
                    TacGia = table.Column<string>(nullable: true),
                    NamXuatBan = table.Column<string>(nullable: true),
                    NhaXuatBan = table.Column<string>(nullable: true),
                    TriGia = table.Column<string>(nullable: true),
                    NgayNhap = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sach", x => x.MaSach);
                });

            migrationBuilder.CreateTable(
                name: "DocGia",
                columns: table => new
                {
                    MaDocGia = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTenDocGia = table.Column<string>(nullable: true),
                    NgaySinh = table.Column<DateTime>(nullable: false),
                    DiaChi = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NgayLapThe = table.Column<DateTime>(nullable: false),
                    NgayHetHan = table.Column<DateTime>(nullable: false),
                    Tien = table.Column<int>(nullable: false),
                    MaPhieuMuon = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocGia", x => x.MaDocGia);
                    table.ForeignKey(
                        name: "FK_DocGia_PhieuMuonSach_MaPhieuMuon",
                        column: x => x.MaPhieuMuon,
                        principalTable: "PhieuMuonSach",
                        principalColumn: "MaPhieuMuon",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietPhieuMuon",
                columns: table => new
                {
                    MaPhieuMuon = table.Column<int>(nullable: false),
                    MaSach = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietPhieuMuon", x => new { x.MaPhieuMuon, x.MaSach });
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuMuon_PhieuMuonSach_MaPhieuMuon",
                        column: x => x.MaPhieuMuon,
                        principalTable: "PhieuMuonSach",
                        principalColumn: "MaPhieuMuon",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuMuon_Sach_MaSach",
                        column: x => x.MaSach,
                        principalTable: "Sach",
                        principalColumn: "MaSach",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhieuThuTien",
                columns: table => new
                {
                    MaPhieuThuTien = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SoTienNo = table.Column<int>(nullable: false),
                    SoTienThu = table.Column<int>(nullable: false),
                    MaDocGia = table.Column<int>(nullable: false),
                    MaNhanVien = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuThuTien", x => x.MaPhieuThuTien);
                    table.ForeignKey(
                        name: "FK_PhieuThuTien_DocGia_MaDocGia",
                        column: x => x.MaDocGia,
                        principalTable: "DocGia",
                        principalColumn: "MaDocGia",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NhanViens",
                columns: table => new
                {
                    MaNhanVien = table.Column<string>(nullable: false),
                    HoTenNhanVien = table.Column<string>(nullable: true),
                    NgaySinh = table.Column<string>(nullable: true),
                    DiaChi = table.Column<string>(nullable: true),
                    DienThoai = table.Column<string>(nullable: true),
                    MaPhieuThuTien = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanViens", x => x.MaNhanVien);
                    table.ForeignKey(
                        name: "FK_NhanViens_PhieuThuTien_MaPhieuThuTien",
                        column: x => x.MaPhieuThuTien,
                        principalTable: "PhieuThuTien",
                        principalColumn: "MaPhieuThuTien",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BangCap",
                columns: table => new
                {
                    MaBang = table.Column<string>(nullable: false),
                    TenBang = table.Column<string>(nullable: true),
                    NhanVienMaNhanVien = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BangCap", x => x.MaBang);
                    table.ForeignKey(
                        name: "FK_BangCap_NhanViens_NhanVienMaNhanVien",
                        column: x => x.NhanVienMaNhanVien,
                        principalTable: "NhanViens",
                        principalColumn: "MaNhanVien",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BangCap_NhanVienMaNhanVien",
                table: "BangCap",
                column: "NhanVienMaNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhieuMuon_MaSach",
                table: "ChiTietPhieuMuon",
                column: "MaSach");

            migrationBuilder.CreateIndex(
                name: "IX_DocGia_MaPhieuMuon",
                table: "DocGia",
                column: "MaPhieuMuon");

            migrationBuilder.CreateIndex(
                name: "IX_NhanViens_MaPhieuThuTien",
                table: "NhanViens",
                column: "MaPhieuThuTien");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuThuTien_MaDocGia",
                table: "PhieuThuTien",
                column: "MaDocGia");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BangCap");

            migrationBuilder.DropTable(
                name: "ChiTietPhieuMuon");

            migrationBuilder.DropTable(
                name: "NhanViens");

            migrationBuilder.DropTable(
                name: "Sach");

            migrationBuilder.DropTable(
                name: "PhieuThuTien");

            migrationBuilder.DropTable(
                name: "DocGia");

            migrationBuilder.DropTable(
                name: "PhieuMuonSach");
        }
    }
}
