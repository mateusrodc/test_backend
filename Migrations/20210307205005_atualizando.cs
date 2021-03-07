using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class atualizando : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Foto",
                table: "Computers",
                type: "varchar(250) CHARACTER SET utf8mb4",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(60) CHARACTER SET utf8mb4",
                oldMaxLength: 60);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Foto",
                table: "Computers",
                type: "varchar(60) CHARACTER SET utf8mb4",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(250) CHARACTER SET utf8mb4",
                oldMaxLength: 250);
        }
    }
}
