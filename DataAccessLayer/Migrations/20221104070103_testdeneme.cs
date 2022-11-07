using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class testdeneme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "kategoriler",
                columns: table => new
                {
                    kategori_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kategori_ad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kategoriler", x => x.kategori_id);
                });

            migrationBuilder.CreateTable(
                name: "meslekler",
                columns: table => new
                {
                    meslek_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    meslek_name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_meslekler", x => x.meslek_id);
                });

            migrationBuilder.CreateTable(
                name: "urunler",
                columns: table => new
                {
                    urun_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    urun_baslik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    urun_aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    urun_fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    urun_stok = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Categorykategori_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_urunler", x => x.urun_id);
                    table.ForeignKey(
                        name: "FK_urunler_kategoriler_Categorykategori_id",
                        column: x => x.Categorykategori_id,
                        principalTable: "kategoriler",
                        principalColumn: "kategori_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "musteriler",
                columns: table => new
                {
                    musteri_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    musteri_mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    musteri_sifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    musteri_ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    musteri_soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kayit_tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Jobmeslek_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_musteriler", x => x.musteri_id);
                    table.ForeignKey(
                        name: "FK_musteriler_meslekler_Jobmeslek_id",
                        column: x => x.Jobmeslek_id,
                        principalTable: "meslekler",
                        principalColumn: "meslek_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "siparisler",
                columns: table => new
                {
                    siparis_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    urun_id = table.Column<int>(type: "int", nullable: false),
                    siparis_no = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    adet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    siparis_tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Producturun_id = table.Column<int>(type: "int", nullable: false),
                    Customersmusteri_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_siparisler", x => x.siparis_id);
                    table.ForeignKey(
                        name: "FK_siparisler_musteriler_Customersmusteri_id",
                        column: x => x.Customersmusteri_id,
                        principalTable: "musteriler",
                        principalColumn: "musteri_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_siparisler_urunler_Producturun_id",
                        column: x => x.Producturun_id,
                        principalTable: "urunler",
                        principalColumn: "urun_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_musteriler_Jobmeslek_id",
                table: "musteriler",
                column: "Jobmeslek_id");

            migrationBuilder.CreateIndex(
                name: "IX_siparisler_Customersmusteri_id",
                table: "siparisler",
                column: "Customersmusteri_id");

            migrationBuilder.CreateIndex(
                name: "IX_siparisler_Producturun_id",
                table: "siparisler",
                column: "Producturun_id");

            migrationBuilder.CreateIndex(
                name: "IX_urunler_Categorykategori_id",
                table: "urunler",
                column: "Categorykategori_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "siparisler");

            migrationBuilder.DropTable(
                name: "musteriler");

            migrationBuilder.DropTable(
                name: "urunler");

            migrationBuilder.DropTable(
                name: "meslekler");

            migrationBuilder.DropTable(
                name: "kategoriler");
        }
    }
}
