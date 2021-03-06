using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Computers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Marca = table.Column<string>(type: "varchar(60) CHARACTER SET utf8mb4", maxLength: 60, nullable: false),
                    Modelo = table.Column<string>(type: "varchar(60) CHARACTER SET utf8mb4", maxLength: 60, nullable: false),
                    PlacaMae = table.Column<string>(type: "varchar(60) CHARACTER SET utf8mb4", maxLength: 60, nullable: false),
                    MemoriaRam = table.Column<string>(type: "varchar(60) CHARACTER SET utf8mb4", maxLength: 60, nullable: false),
                    Hd = table.Column<string>(type: "varchar(60) CHARACTER SET utf8mb4", maxLength: 60, nullable: false),
                    VelocidadeProcessador = table.Column<string>(type: "varchar(60) CHARACTER SET utf8mb4", maxLength: 60, nullable: false),
                    Foto = table.Column<string>(type: "varchar(60) CHARACTER SET utf8mb4", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Computers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Computers");
        }
    }
}
