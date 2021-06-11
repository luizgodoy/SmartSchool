using Microsoft.EntityFrameworkCore;
using SmartSchool.API.Helpers;
using SmartSchool.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.API.Data
{
    public class Repository : IRepository
    {
        private readonly SmartContext _context;

        public Repository(SmartContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() > 0);
        }

        #region Aluno
        public Aluno[] GetAllAlunos(bool includeProfessor = false)
        {
            IQueryable<Aluno> query = _context.Alunos;

            if (includeProfessor)
                query = query.Include(a => a.AlunosDisciplinas)
                             .ThenInclude(ad => ad.Disciplina)
                             .ThenInclude(ap => ap.Professor);

            query = query.AsNoTracking().OrderBy(a => a.Id);

            return query.ToArray();
        }

        public async Task<PageList<Aluno>> GetAllAlunosAsync(PageParams par, bool includeProfessor = false)
        {
            IQueryable<Aluno> query = _context.Alunos;

            if (includeProfessor)
                query = query.Include(a => a.AlunosDisciplinas)
                             .ThenInclude(ad => ad.Disciplina)
                             .ThenInclude(ap => ap.Professor);

            if(par.Ordem.Equals("ASC"))
                query = query.AsNoTracking().OrderBy(a => a.Id);
            else
                query = query.AsNoTracking().OrderByDescending(a => a.Id);

            if (!string.IsNullOrEmpty(par.Nome))
                query = query.Where(aluno => 
                    aluno.Nome.ToUpper().Contains(par.Nome.ToUpper()) ||
                    aluno.Sobrenome.ToUpper().Contains(par.Nome.ToUpper())
                );

            if (par.Matricula > 0)
                query = query.Where(aluno => aluno.Matricula == par.Matricula);

            if (par.Ativo != null)
                query = query.Where(aluno => aluno.Ativo == (par.Ativo != 0));

            return await PageList<Aluno>.CreateAsync(query, par.PageNumber, par.PageSize);
        }

        public Aluno[] GetAllAlunosByDisciplinaId(int disciplinaId, bool includeProfessor = false)
        {
            IQueryable<Aluno> query = _context.Alunos;

            if (includeProfessor)
                query = query.Include(a => a.AlunosDisciplinas)
                             .ThenInclude(ad => ad.Disciplina)
                             .ThenInclude(ap => ap.Professor);

            query = query.AsNoTracking()
                         .OrderBy(a => a.Id)
                         .Where(aluno => aluno.AlunosDisciplinas.Any(ad => ad.DisciplinaId == disciplinaId));

            return query.ToArray();
        }

        public Aluno GetAlunoById(int alunoId, bool includeProfessor = false)
        {
            IQueryable<Aluno> query = _context.Alunos;

            if (includeProfessor)
                query = query.Include(a => a.AlunosDisciplinas)
                    .ThenInclude(ad => ad.Disciplina)
                    .ThenInclude(ap => ap.Professor);

            query = query.AsNoTracking().Where(aluno => aluno.Id == alunoId);

            return query.FirstOrDefault();
        }
        #endregion

        #region Professor
        public Professor[] GetAllProfessores(bool includeAluno = false)
        {
            IQueryable<Professor> query = _context.Professores;

            if (includeAluno)
                query = query.Include(ad => ad.Disciplinas)
                             .ThenInclude(a => a.Alunos);

            query = query.AsNoTracking().OrderBy(a => a.Id);

            return query.ToArray();
        }

        public Professor[] GetAllProfessoresByDisciplinaId(int id, bool includeAluno = false)
        {
            IQueryable<Professor> query = _context.Professores;

            if (includeAluno)
                query = query.Include(ad => ad.Disciplinas)
                             .ThenInclude(a => a.Alunos);

            query = query.AsNoTracking().OrderBy(a => a.Id)
                .Where(a => a.Disciplinas.Any(d => d.Id == id));

            return query.ToArray();
        }

        public Professor GetProfessorById(int id, bool includeAluno = false)
        {
            IQueryable<Professor> query = _context.Professores;

            if (includeAluno)
                query = query.Include(d => d.Disciplinas)
                             .ThenInclude(a => a.Alunos);

            query = query.AsNoTracking().Where(p => p.Id == id);

            return query.FirstOrDefault();
        }
    }
    #endregion 
}
