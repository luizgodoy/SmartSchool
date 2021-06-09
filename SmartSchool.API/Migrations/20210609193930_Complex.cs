using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartSchool.API.Migrations
{
    public partial class Complex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Professores",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Registro",
                table: "Professores",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Sobrenome",
                table: "Professores",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CargaHoraria",
                table: "Disciplinas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CursoId",
                table: "Disciplinas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PreRequisitoId",
                table: "Disciplinas",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataFim",
                table: "AlunosDisciplinas",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataIni",
                table: "AlunosDisciplinas",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Nota",
                table: "AlunosDisciplinas",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Alunos",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataFim",
                table: "Alunos",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataIni",
                table: "Alunos",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataNasc",
                table: "Alunos",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Matricula",
                table: "Alunos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AlunosCursos",
                columns: table => new
                {
                    AlunoId = table.Column<int>(type: "INTEGER", nullable: false),
                    CursoId = table.Column<int>(type: "INTEGER", nullable: false),
                    DataIni = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataFim = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlunosCursos", x => new { x.AlunoId, x.CursoId });
                    table.ForeignKey(
                        name: "FK_AlunosCursos_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlunosCursos_Cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Ativo", "DataIni", "DataNasc", "Matricula" },
                values: new object[] { true, new DateTime(2021, 6, 9, 16, 39, 30, 122, DateTimeKind.Local).AddTicks(8607), new DateTime(2015, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 100 });

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Ativo", "DataIni", "DataNasc", "Matricula" },
                values: new object[] { true, new DateTime(2021, 6, 9, 16, 39, 30, 124, DateTimeKind.Local).AddTicks(1675), new DateTime(2018, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 200 });

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Ativo", "DataIni", "DataNasc", "Matricula" },
                values: new object[] { true, new DateTime(2021, 6, 9, 16, 39, 30, 124, DateTimeKind.Local).AddTicks(1763), new DateTime(2016, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 300 });

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Ativo", "DataIni", "DataNasc", "Matricula" },
                values: new object[] { true, new DateTime(2021, 6, 9, 16, 39, 30, 124, DateTimeKind.Local).AddTicks(1773), new DateTime(2017, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 400 });

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Ativo", "DataIni", "DataNasc", "Matricula" },
                values: new object[] { true, new DateTime(2021, 6, 9, 16, 39, 30, 124, DateTimeKind.Local).AddTicks(1781), new DateTime(2015, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 500 });

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Ativo", "DataIni", "DataNasc", "Matricula" },
                values: new object[] { true, new DateTime(2021, 6, 9, 16, 39, 30, 124, DateTimeKind.Local).AddTicks(1794), new DateTime(2015, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 600 });

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Ativo", "DataIni", "DataNasc", "Matricula" },
                values: new object[] { true, new DateTime(2021, 6, 9, 16, 39, 30, 124, DateTimeKind.Local).AddTicks(1802), new DateTime(2019, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 700 });

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

            migrationBuilder.InsertData(
                table: "Cursos",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 1, "Logística" });

            migrationBuilder.InsertData(
                table: "Cursos",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 3, "Administração" });

            migrationBuilder.InsertData(
                table: "Cursos",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 2, "Sistemas de Informação" });

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Ativo", "Registro", "Sobrenome" },
                values: new object[] { true, 5, "Ignacio" });

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Ativo", "Registro", "Sobrenome" },
                values: new object[] { true, 4, "Pasquini" });

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Ativo", "Registro", "Sobrenome" },
                values: new object[] { true, 3, "Arildo" });

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Ativo", "Nome", "Registro", "Sobrenome" },
                values: new object[] { true, "Rosa", 2, "Cestari" });

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Ativo", "Registro", "Sobrenome" },
                values: new object[] { true, 1, "Abila" });

            migrationBuilder.UpdateData(
                table: "Disciplinas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CursoId", "Nome" },
                values: new object[] { 1, "Cálculo" });

            migrationBuilder.UpdateData(
                table: "Disciplinas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CursoId", "Nome", "ProfessorId" },
                values: new object[] { 2, "Cálculo", 1 });

            migrationBuilder.UpdateData(
                table: "Disciplinas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CursoId", "Nome", "ProfessorId" },
                values: new object[] { 3, "Cálculo", 1 });

            migrationBuilder.UpdateData(
                table: "Disciplinas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CursoId", "Nome", "ProfessorId" },
                values: new object[] { 1, "Administração Geral", 2 });

            migrationBuilder.UpdateData(
                table: "Disciplinas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CursoId", "Nome", "ProfessorId" },
                values: new object[] { 3, "Administração Geral", 2 });

            migrationBuilder.InsertData(
                table: "Disciplinas",
                columns: new[] { "Id", "CargaHoraria", "CursoId", "Nome", "PreRequisitoId", "ProfessorId" },
                values: new object[] { 6, 0, 1, "Português", null, 3 });

            migrationBuilder.InsertData(
                table: "Disciplinas",
                columns: new[] { "Id", "CargaHoraria", "CursoId", "Nome", "PreRequisitoId", "ProfessorId" },
                values: new object[] { 7, 0, 2, "Português", null, 3 });

            migrationBuilder.InsertData(
                table: "Disciplinas",
                columns: new[] { "Id", "CargaHoraria", "CursoId", "Nome", "PreRequisitoId", "ProfessorId" },
                values: new object[] { 10, 0, 2, "Programação", null, 5 });

            migrationBuilder.InsertData(
                table: "Disciplinas",
                columns: new[] { "Id", "CargaHoraria", "CursoId", "Nome", "PreRequisitoId", "ProfessorId" },
                values: new object[] { 8, 0, 3, "Português", null, 3 });

            migrationBuilder.InsertData(
                table: "Disciplinas",
                columns: new[] { "Id", "CargaHoraria", "CursoId", "Nome", "PreRequisitoId", "ProfessorId" },
                values: new object[] { 9, 0, 3, "Inglês", null, 4 });

            migrationBuilder.CreateIndex(
                name: "IX_Disciplinas_CursoId",
                table: "Disciplinas",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_Disciplinas_PreRequisitoId",
                table: "Disciplinas",
                column: "PreRequisitoId");

            migrationBuilder.CreateIndex(
                name: "IX_AlunosCursos_CursoId",
                table: "AlunosCursos",
                column: "CursoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Disciplinas_Cursos_CursoId",
                table: "Disciplinas",
                column: "CursoId",
                principalTable: "Cursos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Disciplinas_Disciplinas_PreRequisitoId",
                table: "Disciplinas",
                column: "PreRequisitoId",
                principalTable: "Disciplinas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Disciplinas_Cursos_CursoId",
                table: "Disciplinas");

            migrationBuilder.DropForeignKey(
                name: "FK_Disciplinas_Disciplinas_PreRequisitoId",
                table: "Disciplinas");

            migrationBuilder.DropTable(
                name: "AlunosCursos");

            migrationBuilder.DropTable(
                name: "Cursos");

            migrationBuilder.DropIndex(
                name: "IX_Disciplinas_CursoId",
                table: "Disciplinas");

            migrationBuilder.DropIndex(
                name: "IX_Disciplinas_PreRequisitoId",
                table: "Disciplinas");

            migrationBuilder.DeleteData(
                table: "Disciplinas",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Disciplinas",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Disciplinas",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Disciplinas",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Disciplinas",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Professores");

            migrationBuilder.DropColumn(
                name: "Registro",
                table: "Professores");

            migrationBuilder.DropColumn(
                name: "Sobrenome",
                table: "Professores");

            migrationBuilder.DropColumn(
                name: "CargaHoraria",
                table: "Disciplinas");

            migrationBuilder.DropColumn(
                name: "CursoId",
                table: "Disciplinas");

            migrationBuilder.DropColumn(
                name: "PreRequisitoId",
                table: "Disciplinas");

            migrationBuilder.DropColumn(
                name: "DataFim",
                table: "AlunosDisciplinas");

            migrationBuilder.DropColumn(
                name: "DataIni",
                table: "AlunosDisciplinas");

            migrationBuilder.DropColumn(
                name: "Nota",
                table: "AlunosDisciplinas");

            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "DataFim",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "DataIni",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "DataNasc",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "Matricula",
                table: "Alunos");

            migrationBuilder.UpdateData(
                table: "Disciplinas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Nome",
                value: "Matemática");

            migrationBuilder.UpdateData(
                table: "Disciplinas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Nome", "ProfessorId" },
                values: new object[] { "Física", 2 });

            migrationBuilder.UpdateData(
                table: "Disciplinas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Nome", "ProfessorId" },
                values: new object[] { "Português", 3 });

            migrationBuilder.UpdateData(
                table: "Disciplinas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Nome", "ProfessorId" },
                values: new object[] { "Inglês", 4 });

            migrationBuilder.UpdateData(
                table: "Disciplinas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Nome", "ProfessorId" },
                values: new object[] { "Programação", 5 });

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 4,
                column: "Nome",
                value: "Rosa II");
        }
    }
}
