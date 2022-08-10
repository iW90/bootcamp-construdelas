using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WoMakersCode.TodoList.Infra.Migrations
{
    public partial class Alarms : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "alarms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataHora = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    IdTaskDetail = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_alarms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_alarms_taskdetails_IdTaskDetail",
                        column: x => x.IdTaskDetail,
                        principalTable: "taskdetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_alarms_IdTaskDetail",
                table: "alarms",
                column: "IdTaskDetail");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "alarms");
        }
    }
}
