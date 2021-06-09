﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmartSchool.API.Data;

namespace SmartSchool.API.Migrations
{
    [DbContext(typeof(SmartContext))]
    [Migration("20210609195452_Complex2")]
    partial class Complex2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.6");

            modelBuilder.Entity("SmartSchool.API.Models.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Ativo")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DataFim")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataIni")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataNasc")
                        .HasColumnType("TEXT");

                    b.Property<int>("Matricula")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sobrenome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefone")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Alunos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ativo = true,
                            DataIni = new DateTime(2021, 6, 9, 16, 54, 52, 46, DateTimeKind.Local).AddTicks(1283),
                            DataNasc = new DateTime(2015, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 100,
                            Nome = "Heitor",
                            Sobrenome = "Godoy",
                            Telefone = "33225555"
                        },
                        new
                        {
                            Id = 2,
                            Ativo = true,
                            DataIni = new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(4185),
                            DataNasc = new DateTime(2018, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 200,
                            Nome = "Gustavo",
                            Sobrenome = "Godoy",
                            Telefone = "3354288"
                        },
                        new
                        {
                            Id = 3,
                            Ativo = true,
                            DataIni = new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(4274),
                            DataNasc = new DateTime(2016, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 300,
                            Nome = "Sofia",
                            Sobrenome = "Rauli",
                            Telefone = "55668899"
                        },
                        new
                        {
                            Id = 4,
                            Ativo = true,
                            DataIni = new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(4285),
                            DataNasc = new DateTime(2017, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 400,
                            Nome = "Alice",
                            Sobrenome = "Abila",
                            Telefone = "6565659"
                        },
                        new
                        {
                            Id = 5,
                            Ativo = true,
                            DataIni = new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(4293),
                            DataNasc = new DateTime(2015, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 500,
                            Nome = "Antonia",
                            Sobrenome = "Ignacio",
                            Telefone = "565685415"
                        },
                        new
                        {
                            Id = 6,
                            Ativo = true,
                            DataIni = new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(4308),
                            DataNasc = new DateTime(2015, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 600,
                            Nome = "Pedro",
                            Sobrenome = "Russo",
                            Telefone = "456454545"
                        },
                        new
                        {
                            Id = 7,
                            Ativo = true,
                            DataIni = new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(4317),
                            DataNasc = new DateTime(2019, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 700,
                            Nome = "Artur",
                            Sobrenome = "Ciciri",
                            Telefone = "9874512"
                        });
                });

            modelBuilder.Entity("SmartSchool.API.Models.AlunoCurso", b =>
                {
                    b.Property<int>("AlunoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CursoId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataFim")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataIni")
                        .HasColumnType("TEXT");

                    b.HasKey("AlunoId", "CursoId");

                    b.HasIndex("CursoId");

                    b.ToTable("AlunosCursos");

                    b.HasData(
                        new
                        {
                            AlunoId = 1,
                            CursoId = 1,
                            DataFim = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataIni = new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(8270)
                        },
                        new
                        {
                            AlunoId = 2,
                            CursoId = 1,
                            DataFim = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataIni = new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(9045)
                        },
                        new
                        {
                            AlunoId = 3,
                            CursoId = 1,
                            DataFim = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataIni = new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(9072)
                        },
                        new
                        {
                            AlunoId = 4,
                            CursoId = 2,
                            DataFim = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataIni = new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(9074)
                        },
                        new
                        {
                            AlunoId = 5,
                            CursoId = 2,
                            DataFim = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataIni = new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(9076)
                        },
                        new
                        {
                            AlunoId = 6,
                            CursoId = 3,
                            DataFim = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataIni = new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(9081)
                        },
                        new
                        {
                            AlunoId = 7,
                            CursoId = 3,
                            DataFim = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataIni = new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(9083)
                        });
                });

            modelBuilder.Entity("SmartSchool.API.Models.AlunoDisciplina", b =>
                {
                    b.Property<int>("AlunoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DisciplinaId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataFim")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataIni")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Nota")
                        .HasColumnType("INTEGER");

                    b.HasKey("AlunoId", "DisciplinaId");

                    b.HasIndex("DisciplinaId");

                    b.ToTable("AlunosDisciplinas");

                    b.HasData(
                        new
                        {
                            AlunoId = 1,
                            DisciplinaId = 2,
                            DataFim = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataIni = new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(5858)
                        },
                        new
                        {
                            AlunoId = 1,
                            DisciplinaId = 4,
                            DataFim = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataIni = new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(6673)
                        },
                        new
                        {
                            AlunoId = 1,
                            DisciplinaId = 5,
                            DataFim = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataIni = new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(6714)
                        },
                        new
                        {
                            AlunoId = 2,
                            DisciplinaId = 1,
                            DataFim = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataIni = new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(6716)
                        },
                        new
                        {
                            AlunoId = 2,
                            DisciplinaId = 2,
                            DataFim = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataIni = new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(6718)
                        },
                        new
                        {
                            AlunoId = 2,
                            DisciplinaId = 5,
                            DataFim = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataIni = new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(6724)
                        },
                        new
                        {
                            AlunoId = 3,
                            DisciplinaId = 1,
                            DataFim = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataIni = new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(6726)
                        },
                        new
                        {
                            AlunoId = 3,
                            DisciplinaId = 2,
                            DataFim = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataIni = new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(6728)
                        },
                        new
                        {
                            AlunoId = 3,
                            DisciplinaId = 3,
                            DataFim = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataIni = new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(6730)
                        },
                        new
                        {
                            AlunoId = 4,
                            DisciplinaId = 1,
                            DataFim = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataIni = new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(6734)
                        },
                        new
                        {
                            AlunoId = 4,
                            DisciplinaId = 4,
                            DataFim = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataIni = new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(6806)
                        },
                        new
                        {
                            AlunoId = 4,
                            DisciplinaId = 5,
                            DataFim = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataIni = new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(6808)
                        },
                        new
                        {
                            AlunoId = 5,
                            DisciplinaId = 4,
                            DataFim = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataIni = new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(6810)
                        },
                        new
                        {
                            AlunoId = 5,
                            DisciplinaId = 5,
                            DataFim = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataIni = new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(6812)
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 1,
                            DataFim = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataIni = new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(6814)
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 2,
                            DataFim = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataIni = new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(6816)
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 3,
                            DataFim = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataIni = new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(6818)
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 4,
                            DataFim = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataIni = new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(6822)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 1,
                            DataFim = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataIni = new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(6824)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 2,
                            DataFim = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataIni = new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(6826)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 3,
                            DataFim = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataIni = new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(6828)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 4,
                            DataFim = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataIni = new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(6830)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 5,
                            DataFim = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataIni = new DateTime(2021, 6, 9, 16, 54, 52, 47, DateTimeKind.Local).AddTicks(6831)
                        });
                });

            modelBuilder.Entity("SmartSchool.API.Models.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Cursos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Logística"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Sistemas de Informação"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Administração"
                        });
                });

            modelBuilder.Entity("SmartSchool.API.Models.Disciplina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CargaHoraria")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CursoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<int?>("PreRequisitoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProfessorId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CursoId");

                    b.HasIndex("PreRequisitoId");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Disciplinas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CargaHoraria = 0,
                            CursoId = 1,
                            Nome = "Cálculo",
                            ProfessorId = 1
                        },
                        new
                        {
                            Id = 2,
                            CargaHoraria = 0,
                            CursoId = 2,
                            Nome = "Cálculo",
                            ProfessorId = 1
                        },
                        new
                        {
                            Id = 3,
                            CargaHoraria = 0,
                            CursoId = 3,
                            Nome = "Cálculo",
                            ProfessorId = 1
                        },
                        new
                        {
                            Id = 4,
                            CargaHoraria = 0,
                            CursoId = 1,
                            Nome = "Administração Geral",
                            ProfessorId = 2
                        },
                        new
                        {
                            Id = 5,
                            CargaHoraria = 0,
                            CursoId = 3,
                            Nome = "Administração Geral",
                            ProfessorId = 2
                        },
                        new
                        {
                            Id = 6,
                            CargaHoraria = 0,
                            CursoId = 1,
                            Nome = "Português",
                            ProfessorId = 3
                        },
                        new
                        {
                            Id = 7,
                            CargaHoraria = 0,
                            CursoId = 2,
                            Nome = "Português",
                            ProfessorId = 3
                        },
                        new
                        {
                            Id = 8,
                            CargaHoraria = 0,
                            CursoId = 3,
                            Nome = "Português",
                            ProfessorId = 3
                        },
                        new
                        {
                            Id = 9,
                            CargaHoraria = 0,
                            CursoId = 3,
                            Nome = "Inglês",
                            ProfessorId = 4
                        },
                        new
                        {
                            Id = 10,
                            CargaHoraria = 0,
                            CursoId = 2,
                            Nome = "Programação",
                            ProfessorId = 5
                        });
                });

            modelBuilder.Entity("SmartSchool.API.Models.Professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Ativo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<int>("Registro")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Sobrenome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Professores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ativo = true,
                            Nome = "Camila",
                            Registro = 5,
                            Sobrenome = "Ignacio"
                        },
                        new
                        {
                            Id = 2,
                            Ativo = true,
                            Nome = "Heloisa",
                            Registro = 4,
                            Sobrenome = "Pasquini"
                        },
                        new
                        {
                            Id = 3,
                            Ativo = true,
                            Nome = "Rosa",
                            Registro = 3,
                            Sobrenome = "Arildo"
                        },
                        new
                        {
                            Id = 4,
                            Ativo = true,
                            Nome = "Rosa",
                            Registro = 2,
                            Sobrenome = "Cestari"
                        },
                        new
                        {
                            Id = 5,
                            Ativo = true,
                            Nome = "Samira",
                            Registro = 1,
                            Sobrenome = "Abila"
                        });
                });

            modelBuilder.Entity("SmartSchool.API.Models.AlunoCurso", b =>
                {
                    b.HasOne("SmartSchool.API.Models.Aluno", "Aluno")
                        .WithMany()
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartSchool.API.Models.Curso", "Curso")
                        .WithMany()
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aluno");

                    b.Navigation("Curso");
                });

            modelBuilder.Entity("SmartSchool.API.Models.AlunoDisciplina", b =>
                {
                    b.HasOne("SmartSchool.API.Models.Aluno", "Aluno")
                        .WithMany("AlunosDisciplinas")
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartSchool.API.Models.Disciplina", "Disciplina")
                        .WithMany("Alunos")
                        .HasForeignKey("DisciplinaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aluno");

                    b.Navigation("Disciplina");
                });

            modelBuilder.Entity("SmartSchool.API.Models.Disciplina", b =>
                {
                    b.HasOne("SmartSchool.API.Models.Curso", "Curso")
                        .WithMany("Disciplinas")
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartSchool.API.Models.Disciplina", "PreRequisito")
                        .WithMany()
                        .HasForeignKey("PreRequisitoId");

                    b.HasOne("SmartSchool.API.Models.Professor", "Professor")
                        .WithMany("Disciplinas")
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Curso");

                    b.Navigation("PreRequisito");

                    b.Navigation("Professor");
                });

            modelBuilder.Entity("SmartSchool.API.Models.Aluno", b =>
                {
                    b.Navigation("AlunosDisciplinas");
                });

            modelBuilder.Entity("SmartSchool.API.Models.Curso", b =>
                {
                    b.Navigation("Disciplinas");
                });

            modelBuilder.Entity("SmartSchool.API.Models.Disciplina", b =>
                {
                    b.Navigation("Alunos");
                });

            modelBuilder.Entity("SmartSchool.API.Models.Professor", b =>
                {
                    b.Navigation("Disciplinas");
                });
#pragma warning restore 612, 618
        }
    }
}