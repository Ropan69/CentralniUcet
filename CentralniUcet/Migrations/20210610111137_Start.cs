using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CentralniUcet.Migrations
{
    public partial class Start : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Autentifikace",
                columns: table => new
                {
                    Veta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Uzivatel = table.Column<string>(type: "varchar(255)", nullable: false),
                    PlatnostDo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatumAktualizace = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autentifikace", x => x.Veta);
                });

            migrationBuilder.CreateTable(
                name: "UcetCentralni",
                columns: table => new
                {
                    Veta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDUcetCentralni = table.Column<int>(type: "int", nullable: false),
                    StavUctu = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "varchar(255)", nullable: false),
                    Heslo = table.Column<string>(type: "varchar(max)", nullable: false),
                    Prijmeni = table.Column<string>(type: "varchar(max)", nullable: false),
                    Jmeno = table.Column<string>(type: "varchar(max)", nullable: false),
                    Stat = table.Column<string>(type: "varchar(2)", nullable: false),
                    SouhlasGDPR = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VychoziIDJidelny = table.Column<int>(type: "int", nullable: false),
                    VychoziIDUctuJidelny = table.Column<string>(type: "varchar(30)", nullable: false),
                    Pohlavi = table.Column<int>(type: "int", nullable: false),
                    Vek = table.Column<int>(type: "int", nullable: false),
                    Mesto = table.Column<string>(type: "varchar(max)", nullable: false),
                    NastaveniApl = table.Column<string>(type: "varchar(max)", nullable: false),
                    DatumAktualizace = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UzivatelAktualizace = table.Column<string>(type: "varchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UcetCentralni", x => x.Veta);
                });

            migrationBuilder.CreateTable(
                name: "OverovaciMail",
                columns: table => new
                {
                    Veta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDOverovacihoMailu = table.Column<long>(type: "bigint", nullable: false),
                    TypMailu = table.Column<int>(type: "int", nullable: false),
                    IDUcetCentralni = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "varchar(max)", nullable: false),
                    PlatnostDo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatumAktualizace = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UzivatelAktualizace = table.Column<string>(type: "varchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OverovaciMail", x => x.Veta);
                    table.ForeignKey(
                        name: "FK_OverovaciMail_UcetCentralni_IDUcetCentralni",
                        column: x => x.IDUcetCentralni,
                        principalTable: "UcetCentralni",
                        principalColumn: "Veta",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UcetJidelny",
                columns: table => new
                {
                    Veta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDUcetCentralni = table.Column<int>(type: "int", nullable: false),
                    IDJidelny = table.Column<int>(type: "int", nullable: false),
                    IDUcetJidelny = table.Column<string>(type: "varchar(30)", nullable: false),
                    PopisUctuJidelny = table.Column<string>(type: "varchar(max)", nullable: false),
                    VynutitOvereniHesla = table.Column<bool>(type: "bit", nullable: false),
                    DatumAktualizace = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UzivatelAktualizace = table.Column<string>(type: "varchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UcetJidelny", x => x.Veta);
                    table.ForeignKey(
                        name: "FK_UcetJidelny_UcetCentralni_IDUcetCentralni",
                        column: x => x.IDUcetCentralni,
                        principalTable: "UcetCentralni",
                        principalColumn: "Veta",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Autentifikace_Uzivatel",
                table: "Autentifikace",
                column: "Uzivatel",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OverovaciMail_IDUcetCentralni",
                table: "OverovaciMail",
                column: "IDUcetCentralni");

            migrationBuilder.CreateIndex(
                name: "IX_UcetCentralni_Email",
                table: "UcetCentralni",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UcetCentralni_IDUcetCentralni",
                table: "UcetCentralni",
                column: "IDUcetCentralni",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UcetJidelny_IDUcetCentralni",
                table: "UcetJidelny",
                column: "IDUcetCentralni");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Autentifikace");

            migrationBuilder.DropTable(
                name: "OverovaciMail");

            migrationBuilder.DropTable(
                name: "UcetJidelny");

            migrationBuilder.DropTable(
                name: "UcetCentralni");
        }
    }
}
