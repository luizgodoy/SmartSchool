using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartSchool.API.Migrations
{
    public partial class Complex2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataIni",
                value: new DateTime(2021, 6, 9, 16, 54, 52, 46, DateTimeKind.Local).AddTicks(1283));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataIni",
                value: new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataIni",
                value: new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(4274));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataIni",
                value: new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(4285));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataIni",
                value: new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(4293));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataIni",
                value: new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(4308));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataIni",
                value: new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(4317));

            migrationBuilder.InsertData(
                table: "AlunosCursos",
                columns: new[] { "AlunoId", "CursoId", "DataFim", "DataIni" },
                values: new object[] { 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(8270) });

            migrationBuilder.InsertData(
                table: "AlunosCursos",
                columns: new[] { "AlunoId", "CursoId", "DataFim", "DataIni" },
                values: new object[] { 6, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(9081) });

            migrationBuilder.InsertData(
                table: "AlunosCursos",
                columns: new[] { "AlunoId", "CursoId", "DataFim", "DataIni" },
                values: new object[] { 5, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(9076) });

            migrationBuilder.InsertData(
                table: "AlunosCursos",
                columns: new[] { "AlunoId", "CursoId", "DataFim", "DataIni" },
                values: new object[] { 4, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(9074) });

            migrationBuilder.InsertData(
                table: "AlunosCursos",
                columns: new[] { "AlunoId", "CursoId", "DataFim", "DataIni" },
                values: new object[] { 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(9072) });

            migrationBuilder.InsertData(
                table: "AlunosCursos",
                columns: new[] { "AlunoId", "CursoId", "DataFim", "DataIni" },
                values: new object[] { 2, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(9045) });

            migrationBuilder.InsertData(
                table: "AlunosCursos",
                columns: new[] { "AlunoId", "CursoId", "DataFim", "DataIni" },
                values: new object[] { 7, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(9083) });

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 1, 2 },
                column: "DataIni",
                value: new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(5858));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 1, 4 },
                column: "DataIni",
                value: new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(6673));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 1, 5 },
                column: "DataIni",
                value: new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(6714));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 2, 1 },
                column: "DataIni",
                value: new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(6716));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 2, 2 },
                column: "DataIni",
                value: new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(6718));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 2, 5 },
                column: "DataIni",
                value: new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 3, 1 },
                column: "DataIni",
                value: new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(6726));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 3, 2 },
                column: "DataIni",
                value: new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(6728));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 3, 3 },
                column: "DataIni",
                value: new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 4, 1 },
                column: "DataIni",
                value: new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(6734));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 4, 4 },
                column: "DataIni",
                value: new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(6806));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 4, 5 },
                column: "DataIni",
                value: new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(6808));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 5, 4 },
                column: "DataIni",
                value: new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 5, 5 },
                column: "DataIni",
                value: new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(6812));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 6, 1 },
                column: "DataIni",
                value: new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(6814));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 6, 2 },
                column: "DataIni",
                value: new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(6816));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 6, 3 },
                column: "DataIni",
                value: new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(6818));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 6, 4 },
                column: "DataIni",
                value: new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(6822));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 1 },
                column: "DataIni",
                value: new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(6824));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 2 },
                column: "DataIni",
                value: new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(6826));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 3 },
                column: "DataIni",
                value: new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(6828));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 4 },
                column: "DataIni",
                value: new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 5 },
                column: "DataIni",
                value: new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(6831));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AlunosCursos",
                keyColumns: new[] { "AlunoId", "CursoId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "AlunosCursos",
                keyColumns: new[] { "AlunoId", "CursoId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "AlunosCursos",
                keyColumns: new[] { "AlunoId", "CursoId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "AlunosCursos",
                keyColumns: new[] { "AlunoId", "CursoId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "AlunosCursos",
                keyColumns: new[] { "AlunoId", "CursoId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "AlunosCursos",
                keyColumns: new[] { "AlunoId", "CursoId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "AlunosCursos",
                keyColumns: new[] { "AlunoId", "CursoId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataIni",
                value: new DateTime(2021, 6, 9, 16, 39, 30, 122, DateTimeKind.Local).AddTicks(8607));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataIni",
                value: new DateTime(2021, 6, 9, 16, 39, 30, 124, DateTimeKind.Local).AddTicks(1675));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataIni",
                value: new DateTime(2021, 6, 9, 16, 39, 30, 124, DateTimeKind.Local).AddTicks(1763));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataIni",
                value: new DateTime(2021, 6, 9, 16, 39, 30, 124, DateTimeKind.Local).AddTicks(1773));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataIni",
                value: new DateTime(2021, 6, 9, 16, 39, 30, 124, DateTimeKind.Local).AddTicks(1781));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataIni",
                value: new DateTime(2021, 6, 9, 16, 39, 30, 124, DateTimeKind.Local).AddTicks(1794));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataIni",
                value: new DateTime(2021, 6, 9, 16, 39, 30, 124, DateTimeKind.Local).AddTicks(1802));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 1, 2 },
                column: "DataIni",
                value: new DateTime(2021, 6, 9, 16, 39, 30, 124, DateTimeKind.Local).AddTicks(3299));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 1, 4 },
                column: "DataIni",
                value: new DateTime(2021, 6, 9, 16, 39, 30, 124, DateTimeKind.Local).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 1, 5 },
                column: "DataIni",
                value: new DateTime(2021, 6, 9, 16, 39, 30, 124, DateTimeKind.Local).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 2, 1 },
                column: "DataIni",
                value: new DateTime(2021, 6, 9, 16, 39, 30, 124, DateTimeKind.Local).AddTicks(4175));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 2, 2 },
                column: "DataIni",
                value: new DateTime(2021, 6, 9, 16, 39, 30, 124, DateTimeKind.Local).AddTicks(4177));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 2, 5 },
                column: "DataIni",
                value: new DateTime(2021, 6, 9, 16, 39, 30, 124, DateTimeKind.Local).AddTicks(4183));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 3, 1 },
                column: "DataIni",
                value: new DateTime(2021, 6, 9, 16, 39, 30, 124, DateTimeKind.Local).AddTicks(4184));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 3, 2 },
                column: "DataIni",
                value: new DateTime(2021, 6, 9, 16, 39, 30, 124, DateTimeKind.Local).AddTicks(4187));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 3, 3 },
                column: "DataIni",
                value: new DateTime(2021, 6, 9, 16, 39, 30, 124, DateTimeKind.Local).AddTicks(4188));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 4, 1 },
                column: "DataIni",
                value: new DateTime(2021, 6, 9, 16, 39, 30, 124, DateTimeKind.Local).AddTicks(4192));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 4, 4 },
                column: "DataIni",
                value: new DateTime(2021, 6, 9, 16, 39, 30, 124, DateTimeKind.Local).AddTicks(4195));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 4, 5 },
                column: "DataIni",
                value: new DateTime(2021, 6, 9, 16, 39, 30, 124, DateTimeKind.Local).AddTicks(4197));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 5, 4 },
                column: "DataIni",
                value: new DateTime(2021, 6, 9, 16, 39, 30, 124, DateTimeKind.Local).AddTicks(4198));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 5, 5 },
                column: "DataIni",
                value: new DateTime(2021, 6, 9, 16, 39, 30, 124, DateTimeKind.Local).AddTicks(4200));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 6, 1 },
                column: "DataIni",
                value: new DateTime(2021, 6, 9, 16, 39, 30, 124, DateTimeKind.Local).AddTicks(4202));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 6, 2 },
                column: "DataIni",
                value: new DateTime(2021, 6, 9, 16, 39, 30, 124, DateTimeKind.Local).AddTicks(4204));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 6, 3 },
                column: "DataIni",
                value: new DateTime(2021, 6, 9, 16, 39, 30, 124, DateTimeKind.Local).AddTicks(4206));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 6, 4 },
                column: "DataIni",
                value: new DateTime(2021, 6, 9, 16, 39, 30, 124, DateTimeKind.Local).AddTicks(4210));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 1 },
                column: "DataIni",
                value: new DateTime(2021, 6, 9, 16, 39, 30, 124, DateTimeKind.Local).AddTicks(4211));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 2 },
                column: "DataIni",
                value: new DateTime(2021, 6, 9, 16, 39, 30, 124, DateTimeKind.Local).AddTicks(4213));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 3 },
                column: "DataIni",
                value: new DateTime(2021, 6, 9, 16, 39, 30, 124, DateTimeKind.Local).AddTicks(4215));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 4 },
                column: "DataIni",
                value: new DateTime(2021, 6, 9, 16, 39, 30, 124, DateTimeKind.Local).AddTicks(4217));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 5 },
                column: "DataIni",
                value: new DateTime(2021, 6, 9, 16, 39, 30, 124, DateTimeKind.Local).AddTicks(4219));
        }
    }
}
