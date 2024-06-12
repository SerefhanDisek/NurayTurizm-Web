using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class TurDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personeller",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kidem = table.Column<int>(type: "int", nullable: false),
                    Maas = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TelNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaasGunu = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TCNO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vize = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personeller", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TahsilatTurleri",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TahsilatTurleri", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TurAltKategorileri",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TurAltKategorileri", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TurKategorileri",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TurKategorileri", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Ulkeler",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ulkeler", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Tahsilatlar",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tutar = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TahsilatTuruID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tahsilatlar", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Tahsilatlar_TahsilatTurleri_TahsilatTuruID",
                        column: x => x.TahsilatTuruID,
                        principalTable: "TahsilatTurleri",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Turlar",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Açıklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AktifMi = table.Column<bool>(type: "bit", nullable: false),
                    ÜyeOluşTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    YurtİçiMi = table.Column<bool>(type: "bit", nullable: false),
                    YurtDışıMı = table.Column<bool>(type: "bit", nullable: false),
                    TurAltKategoriID = table.Column<int>(type: "int", nullable: true),
                    TurKategoriID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turlar", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Turlar_TurAltKategorileri_TurAltKategoriID",
                        column: x => x.TurAltKategoriID,
                        principalTable: "TurAltKategorileri",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Turlar_TurKategorileri_TurKategoriID",
                        column: x => x.TurKategoriID,
                        principalTable: "TurKategorileri",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Lokasyonlar",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TurLokasyonu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BulunduguUlkeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lokasyonlar", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Lokasyonlar_Ulkeler_BulunduguUlkeID",
                        column: x => x.BulunduguUlkeID,
                        principalTable: "Ulkeler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Faturalar",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tutar = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DuzenlenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BelgeNO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TahsilatID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faturalar", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Faturalar_Tahsilatlar_TahsilatID",
                        column: x => x.TahsilatID,
                        principalTable: "Tahsilatlar",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Adresler",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdresAdı = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    İl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    İlçe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mahalle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sokak = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TurID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adresler", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Adresler_Turlar_TurID",
                        column: x => x.TurID,
                        principalTable: "Turlar",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GeziProgramlari",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KacKisilik = table.Column<int>(type: "int", nullable: false),
                    Vasita = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KalinacakYer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KacGun = table.Column<int>(type: "int", nullable: false),
                    SeyahatIpuculari = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TurID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeziProgramlari", x => x.ID);
                    table.ForeignKey(
                        name: "FK_GeziProgramlari_Turlar_TurID",
                        column: x => x.TurID,
                        principalTable: "Turlar",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TuraKayitlar",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NetFiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BrutFiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Indirim = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KayitNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TurID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TuraKayitlar", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TuraKayitlar_Turlar_TurID",
                        column: x => x.TurID,
                        principalTable: "Turlar",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adresler_TurID",
                table: "Adresler",
                column: "TurID");

            migrationBuilder.CreateIndex(
                name: "IX_Faturalar_TahsilatID",
                table: "Faturalar",
                column: "TahsilatID");

            migrationBuilder.CreateIndex(
                name: "IX_GeziProgramlari_TurID",
                table: "GeziProgramlari",
                column: "TurID");

            migrationBuilder.CreateIndex(
                name: "IX_Lokasyonlar_BulunduguUlkeID",
                table: "Lokasyonlar",
                column: "BulunduguUlkeID");

            migrationBuilder.CreateIndex(
                name: "IX_Tahsilatlar_TahsilatTuruID",
                table: "Tahsilatlar",
                column: "TahsilatTuruID");

            migrationBuilder.CreateIndex(
                name: "IX_TuraKayitlar_TurID",
                table: "TuraKayitlar",
                column: "TurID");

            migrationBuilder.CreateIndex(
                name: "IX_Turlar_TurAltKategoriID",
                table: "Turlar",
                column: "TurAltKategoriID");

            migrationBuilder.CreateIndex(
                name: "IX_Turlar_TurKategoriID",
                table: "Turlar",
                column: "TurKategoriID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adresler");

            migrationBuilder.DropTable(
                name: "Faturalar");

            migrationBuilder.DropTable(
                name: "GeziProgramlari");

            migrationBuilder.DropTable(
                name: "Lokasyonlar");

            migrationBuilder.DropTable(
                name: "Personeller");

            migrationBuilder.DropTable(
                name: "TuraKayitlar");

            migrationBuilder.DropTable(
                name: "Tahsilatlar");

            migrationBuilder.DropTable(
                name: "Ulkeler");

            migrationBuilder.DropTable(
                name: "Turlar");

            migrationBuilder.DropTable(
                name: "TahsilatTurleri");

            migrationBuilder.DropTable(
                name: "TurAltKategorileri");

            migrationBuilder.DropTable(
                name: "TurKategorileri");
        }
    }
}
