using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PontoEletronicoMVC.Migrations
{
    public partial class tempoTotal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<TimeSpan>(
                name: "TotalTempo",
                table: "RegistroPonto",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalTempo",
                table: "RegistroPonto");
        }
    }
}
