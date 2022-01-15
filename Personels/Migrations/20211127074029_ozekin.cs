using Microsoft.EntityFrameworkCore.Migrations;

namespace Personels.Migrations
{
    public partial class ozekin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Birims",
                columns: table => new
                {
                    BirimId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BirimAdı = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Birims", x => x.BirimId);
                });

            migrationBuilder.CreateTable(
                name: "Departmanlars",
                columns: table => new
                {
                    DepartId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartKodu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departmanlars", x => x.DepartId);
                });

            migrationBuilder.CreateTable(
                name: "Isims",
                columns: table => new
                {
                    IsimId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsimAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsimKodu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Isims", x => x.IsimId);
                });

            migrationBuilder.CreateTable(
                name: "Metrajs",
                columns: table => new
                {
                    MetrajId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MetrajAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetrajKodu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Metrajs", x => x.MetrajId);
                });

            migrationBuilder.CreateTable(
                name: "Olcus",
                columns: table => new
                {
                    OlcuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OlcuAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlcuKodu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Olcus", x => x.OlcuId);
                });

            migrationBuilder.CreateTable(
                name: "Renks",
                columns: table => new
                {
                    RenkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RenkAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RenkKodu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Renks", x => x.RenkId);
                });

            migrationBuilder.CreateTable(
                name: "Seris",
                columns: table => new
                {
                    SeriId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeriAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeriKodu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seris", x => x.SeriId);
                });

            migrationBuilder.CreateTable(
                name: "Urun",
                columns: table => new
                {
                    UrunId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrunKodu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urun", x => x.UrunId);
                });

            migrationBuilder.CreateTable(
                name: "Personels",
                columns: table => new
                {
                    PersonelID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sehir = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirimID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personels", x => x.PersonelID);
                    table.ForeignKey(
                        name: "FK_Personels_Birims_BirimID",
                        column: x => x.BirimID,
                        principalTable: "Birims",
                        principalColumn: "BirimId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Kodlars",
                columns: table => new
                {
                    KodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KodNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KodAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlcuId = table.Column<int>(type: "int", nullable: false),
                    MetrajId = table.Column<int>(type: "int", nullable: false),
                    RenkId = table.Column<int>(type: "int", nullable: false),
                    IsimId = table.Column<int>(type: "int", nullable: false),
                    SeriId = table.Column<int>(type: "int", nullable: false),
                    UrunId = table.Column<int>(type: "int", nullable: false),
                    DepartmanlarDepartId = table.Column<int>(type: "int", nullable: true),
                    DepartmanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kodlars", x => x.KodId);
                    table.ForeignKey(
                        name: "FK_Kodlars_Departmanlars_DepartmanlarDepartId",
                        column: x => x.DepartmanlarDepartId,
                        principalTable: "Departmanlars",
                        principalColumn: "DepartId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Kodlars_Isims_IsimId",
                        column: x => x.IsimId,
                        principalTable: "Isims",
                        principalColumn: "IsimId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kodlars_Metrajs_MetrajId",
                        column: x => x.MetrajId,
                        principalTable: "Metrajs",
                        principalColumn: "MetrajId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kodlars_Olcus_OlcuId",
                        column: x => x.OlcuId,
                        principalTable: "Olcus",
                        principalColumn: "OlcuId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kodlars_Renks_RenkId",
                        column: x => x.RenkId,
                        principalTable: "Renks",
                        principalColumn: "RenkId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kodlars_Seris_SeriId",
                        column: x => x.SeriId,
                        principalTable: "Seris",
                        principalColumn: "SeriId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kodlars_Urun_UrunId",
                        column: x => x.UrunId,
                        principalTable: "Urun",
                        principalColumn: "UrunId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kodlars_DepartmanlarDepartId",
                table: "Kodlars",
                column: "DepartmanlarDepartId");

            migrationBuilder.CreateIndex(
                name: "IX_Kodlars_IsimId",
                table: "Kodlars",
                column: "IsimId");

            migrationBuilder.CreateIndex(
                name: "IX_Kodlars_MetrajId",
                table: "Kodlars",
                column: "MetrajId");

            migrationBuilder.CreateIndex(
                name: "IX_Kodlars_OlcuId",
                table: "Kodlars",
                column: "OlcuId");

            migrationBuilder.CreateIndex(
                name: "IX_Kodlars_RenkId",
                table: "Kodlars",
                column: "RenkId");

            migrationBuilder.CreateIndex(
                name: "IX_Kodlars_SeriId",
                table: "Kodlars",
                column: "SeriId");

            migrationBuilder.CreateIndex(
                name: "IX_Kodlars_UrunId",
                table: "Kodlars",
                column: "UrunId");

            migrationBuilder.CreateIndex(
                name: "IX_Personels_BirimID",
                table: "Personels",
                column: "BirimID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kodlars");

            migrationBuilder.DropTable(
                name: "Personels");

            migrationBuilder.DropTable(
                name: "Departmanlars");

            migrationBuilder.DropTable(
                name: "Isims");

            migrationBuilder.DropTable(
                name: "Metrajs");

            migrationBuilder.DropTable(
                name: "Olcus");

            migrationBuilder.DropTable(
                name: "Renks");

            migrationBuilder.DropTable(
                name: "Seris");

            migrationBuilder.DropTable(
                name: "Urun");

            migrationBuilder.DropTable(
                name: "Birims");
        }
    }
}
