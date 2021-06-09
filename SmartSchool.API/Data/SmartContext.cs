using Microsoft.EntityFrameworkCore;
using SmartSchool.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.API.Data
{
    public class SmartContext : DbContext
    {
        public SmartContext(DbContextOptions<SmartContext> options) : base(options) { }

        public DbSet<Aluno> Alunos { get; set; }

        public DbSet<AlunoCurso> AlunosCursos { get; set; }

        public DbSet<AlunoDisciplina> AlunosDisciplinas { get; set; }

        public DbSet<Curso> Cursos { get; set; }

        public DbSet<Professor> Professores { get; set; }

        public DbSet<Disciplina> Disciplinas { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<AlunoDisciplina>()
                .HasKey(AD => new { AD.AlunoId, AD.DisciplinaId });

            builder.Entity<AlunoCurso>()
                .HasKey(AC => new { AC.AlunoId, AC.CursoId });

            builder.Entity<Professor>()
                .HasData(new List<Professor>(){
                    new Professor(1, 5, "Camila","Ignacio"),
                    new Professor(2, 4, "Heloisa","Pasquini"),
                    new Professor(3, 3, "Rosa","Arildo"),
                    new Professor(4, 2, "Rosa","Cestari"),
                    new Professor(5, 1, "Samira", "Abila")
                });

            builder.Entity<Curso>()
                .HasData(new List<Curso>
                {
                    new Curso(1, "Logística"),
                    new Curso(2, "Sistemas de Informação"),
                    new Curso(3, "Administração")
                });                

            builder.Entity<Disciplina>()
                .HasData(new List<Disciplina>{
                    new Disciplina(1, "Cálculo", 1, 1),
                    new Disciplina(2, "Cálculo", 1, 2),
                    new Disciplina(3, "Cálculo", 1, 3),
                    new Disciplina(4, "Administração Geral", 2, 1),
                    new Disciplina(5, "Administração Geral", 2, 3),
                    new Disciplina(6, "Português", 3, 1),
                    new Disciplina(7, "Português", 3, 2),
                    new Disciplina(8, "Português", 3, 3),
                    new Disciplina(9, "Inglês", 4, 3),
                    new Disciplina(10, "Programação", 5, 2)
                });

            builder.Entity<Aluno>()
                .HasData(new List<Aluno>(){
                    new Aluno(1, 100, "Heitor", "Godoy", "33225555",DateTime.Parse("28/04/2015")),
                    new Aluno(2, 200, "Gustavo", "Godoy", "3354288",DateTime.Parse("29/05/2018")),
                    new Aluno(3, 300, "Sofia", "Rauli", "55668899",DateTime.Parse("15/03/2016")),
                    new Aluno(4, 400, "Alice", "Abila", "6565659",DateTime.Parse("06/01/2017")),
                    new Aluno(5, 500, "Antonia", "Ignacio", "565685415",DateTime.Parse("18/06/2015")),
                    new Aluno(6, 600, "Pedro", "Russo", "456454545",DateTime.Parse("13/02/2015")),
                    new Aluno(7, 700, "Artur", "Ciciri", "9874512",DateTime.Parse("25/12/2019"))
                });

            builder.Entity<AlunoDisciplina>()
                .HasData(new List<AlunoDisciplina>() {
                    new AlunoDisciplina() {AlunoId = 1, DisciplinaId = 2 },
                    new AlunoDisciplina() {AlunoId = 1, DisciplinaId = 4 },
                    new AlunoDisciplina() {AlunoId = 1, DisciplinaId = 5 },
                    new AlunoDisciplina() {AlunoId = 2, DisciplinaId = 1 },
                    new AlunoDisciplina() {AlunoId = 2, DisciplinaId = 2 },
                    new AlunoDisciplina() {AlunoId = 2, DisciplinaId = 5 },
                    new AlunoDisciplina() {AlunoId = 3, DisciplinaId = 1 },
                    new AlunoDisciplina() {AlunoId = 3, DisciplinaId = 2 },
                    new AlunoDisciplina() {AlunoId = 3, DisciplinaId = 3 },
                    new AlunoDisciplina() {AlunoId = 4, DisciplinaId = 1 },
                    new AlunoDisciplina() {AlunoId = 4, DisciplinaId = 4 },
                    new AlunoDisciplina() {AlunoId = 4, DisciplinaId = 5 },
                    new AlunoDisciplina() {AlunoId = 5, DisciplinaId = 4 },
                    new AlunoDisciplina() {AlunoId = 5, DisciplinaId = 5 },
                    new AlunoDisciplina() {AlunoId = 6, DisciplinaId = 1 },
                    new AlunoDisciplina() {AlunoId = 6, DisciplinaId = 2 },
                    new AlunoDisciplina() {AlunoId = 6, DisciplinaId = 3 },
                    new AlunoDisciplina() {AlunoId = 6, DisciplinaId = 4 },
                    new AlunoDisciplina() {AlunoId = 7, DisciplinaId = 1 },
                    new AlunoDisciplina() {AlunoId = 7, DisciplinaId = 2 },
                    new AlunoDisciplina() {AlunoId = 7, DisciplinaId = 3 },
                    new AlunoDisciplina() {AlunoId = 7, DisciplinaId = 4 },
                    new AlunoDisciplina() {AlunoId = 7, DisciplinaId = 5 }
                });

            builder.Entity<AlunoCurso>()
                .HasData(new List<AlunoCurso>() {
                    new AlunoCurso() {AlunoId = 1, CursoId = 1 },
                    new AlunoCurso() {AlunoId = 2, CursoId = 1 },
                    new AlunoCurso() {AlunoId = 3, CursoId = 1 },
                    new AlunoCurso() {AlunoId = 4, CursoId = 2 },
                    new AlunoCurso() {AlunoId = 5, CursoId = 2 },
                    new AlunoCurso() {AlunoId = 6, CursoId = 3 },
                    new AlunoCurso() {AlunoId = 7, CursoId = 3 }
                });
        }
    }
}