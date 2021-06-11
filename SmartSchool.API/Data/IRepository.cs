using SmartSchool.API.Helpers;
using SmartSchool.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.API.Data
{
    public interface IRepository
    {
        void Add<T>(T entity) where T : class;

        void Update<T>(T entity) where T : class;

        void Delete<T>(T entity) where T : class;

        bool SaveChanges();

        Aluno[] GetAllAlunos(bool includeProfessor = false);

        Task<PageList<Aluno>> GetAllAlunosAsync(PageParams par, bool includeProfessor = false);

        Aluno[] GetAllAlunosByDisciplinaId(int disciplinaId, bool includeProfessor = false);

        Aluno GetAlunoById(int alunoId, bool includeProfessor = false);

        Professor[] GetAllProfessores(bool includeAluno = false);

        Professor[] GetAllProfessoresByDisciplinaId(int id, bool includeAluno = false);

        Professor GetProfessorById(int id, bool includeAluno = false);
    }
}
