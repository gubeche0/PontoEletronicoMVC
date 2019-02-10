using Microsoft.EntityFrameworkCore.Migrations;

namespace PontoEletronicoMVC.Migrations
{
    public partial class PontoRegistro2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RegistroPonto_Usuario_UsuarioId",
                table: "RegistroPonto");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "RegistroPonto",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_RegistroPonto_Usuario_UsuarioId",
                table: "RegistroPonto",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RegistroPonto_Usuario_UsuarioId",
                table: "RegistroPonto");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "RegistroPonto",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_RegistroPonto_Usuario_UsuarioId",
                table: "RegistroPonto",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
