using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WoMakersCode.TodoList.Infra.Migrations
{
    public partial class TabelaTaskDetais : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "taskdetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "VARCHAR(300)", nullable: false),
                    DataHora = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    Executado = table.Column<int>(type: "INT", nullable: false),
                    IdTaskList = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_taskdetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_taskdetails_tasklists_IdTaskList",
                        column: x => x.IdTaskList,
                        principalTable: "tasklists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_taskdetails_IdTaskList",
                table: "taskdetails",
                column: "IdTaskList");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "taskdetails");
        }
    }
}
