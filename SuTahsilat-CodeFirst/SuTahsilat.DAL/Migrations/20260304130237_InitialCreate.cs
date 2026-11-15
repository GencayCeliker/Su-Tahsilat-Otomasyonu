using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuTahsilat.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ABONE",
                columns: table => new
                {
                    AboneID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TCKimlikNo = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ABONE", x => x.AboneID);
                });

            migrationBuilder.CreateTable(
                name: "TARIFE",
                columns: table => new
                {
                    TarifeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TarifeAdi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TARIFE", x => x.TarifeID);
                });

            migrationBuilder.CreateTable(
                name: "SAYAC",
                columns: table => new
                {
                    SayacID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboneID = table.Column<int>(type: "int", nullable: false),
                    TarifeID = table.Column<int>(type: "int", nullable: false),
                    Marka = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SeriNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SAYAC", x => x.SayacID);
                    table.ForeignKey(
                        name: "FK_SAYAC_ABONE_AboneID",
                        column: x => x.AboneID,
                        principalTable: "ABONE",
                        principalColumn: "AboneID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SAYAC_TARIFE_TarifeID",
                        column: x => x.TarifeID,
                        principalTable: "TARIFE",
                        principalColumn: "TarifeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UCRET",
                columns: table => new
                {
                    UcretID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TarifeID = table.Column<int>(type: "int", nullable: false),
                    GecerliTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BirimFiyat = table.Column<decimal>(type: "decimal(20,2)", nullable: false),
                    CTVOrani = table.Column<decimal>(type: "decimal(3,2)", nullable: false),
                    ABOrani = table.Column<decimal>(type: "decimal(3,2)", nullable: false),
                    KDVOrani = table.Column<decimal>(type: "decimal(3,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UCRET", x => x.UcretID);
                    table.ForeignKey(
                        name: "FK_UCRET_TARIFE_TarifeID",
                        column: x => x.TarifeID,
                        principalTable: "TARIFE",
                        principalColumn: "TarifeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TUKETIM",
                columns: table => new
                {
                    TuketimID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SayacID = table.Column<int>(type: "int", nullable: false),
                    TuketimTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Endeks = table.Column<int>(type: "int", nullable: false),
                    TuketilenMiktari = table.Column<int>(type: "int", nullable: false),
                    Tutar = table.Column<decimal>(type: "decimal(20,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TUKETIM", x => x.TuketimID);
                    table.ForeignKey(
                        name: "FK_TUKETIM_SAYAC_SayacID",
                        column: x => x.SayacID,
                        principalTable: "SAYAC",
                        principalColumn: "SayacID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ABONE_TCKimlikNo",
                table: "ABONE",
                column: "TCKimlikNo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SAYAC_AboneID",
                table: "SAYAC",
                column: "AboneID");

            migrationBuilder.CreateIndex(
                name: "IX_SAYAC_SeriNo",
                table: "SAYAC",
                column: "SeriNo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SAYAC_TarifeID",
                table: "SAYAC",
                column: "TarifeID");

            migrationBuilder.CreateIndex(
                name: "IX_TUKETIM_SayacID",
                table: "TUKETIM",
                column: "SayacID");

            migrationBuilder.CreateIndex(
                name: "IX_TUKETIM_TuketimTarihi",
                table: "TUKETIM",
                column: "TuketimTarihi",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UCRET_TarifeID",
                table: "UCRET",
                column: "TarifeID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TUKETIM");

            migrationBuilder.DropTable(
                name: "UCRET");

            migrationBuilder.DropTable(
                name: "SAYAC");

            migrationBuilder.DropTable(
                name: "ABONE");

            migrationBuilder.DropTable(
                name: "TARIFE");
        }
    }
}
