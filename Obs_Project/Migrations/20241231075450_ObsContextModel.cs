using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Obs_Project.Migrations
{
    /// <inheritdoc />
    public partial class ObsContextModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ders",
                columns: table => new
                {
                    DersId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DersKod = table.Column<int>(type: "int", nullable: false),
                    DersAd = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ders", x => x.DersId);
                });

            migrationBuilder.CreateTable(
                name: "Siniflar",
                columns: table => new
                {
                    SinifID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SinifAd = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    Kontenjan = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Siniflar", x => x.SinifID);
                });

            migrationBuilder.CreateTable(
                name: "Ogrenciler",
                columns: table => new
                {
                    OgrenciID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Soyad = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Numara = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SinifID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrenciler", x => x.OgrenciID);
                    table.ForeignKey(
                        name: "FK_Ogrenciler_Siniflar_SinifID",
                        column: x => x.SinifID,
                        principalTable: "Siniflar",
                        principalColumn: "SinifID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OgrenciDers",
                columns: table => new
                {
                    DersID = table.Column<int>(type: "int", nullable: false),
                    OgrenciID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgrenciDers", x => new { x.OgrenciID, x.DersID });
                    table.ForeignKey(
                        name: "FK_OgrenciDers_Ders_DersID",
                        column: x => x.DersID,
                        principalTable: "Ders",
                        principalColumn: "DersId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OgrenciDers_Ogrenciler_OgrenciID",
                        column: x => x.OgrenciID,
                        principalTable: "Ogrenciler",
                        principalColumn: "OgrenciID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OgrenciDers_DersID",
                table: "OgrenciDers",
                column: "DersID");

            migrationBuilder.CreateIndex(
                name: "IX_Ogrenciler_SinifID",
                table: "Ogrenciler",
                column: "SinifID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OgrenciDers");

            migrationBuilder.DropTable(
                name: "Ders");

            migrationBuilder.DropTable(
                name: "Ogrenciler");

            migrationBuilder.DropTable(
                name: "Siniflar");
        }
    }
}
