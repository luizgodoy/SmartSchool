using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartSchool.API.Data;
using SmartSchool.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SmartSchool.API.Controllers
{
    /// <summary>
    /// Controller de professor
    /// </summary>
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]    
    public class ProfessorController : ControllerBase
    {
        private readonly IRepository _repos;

        /// <summary>
        /// Contrutor da controller de professor
        /// </summary>
        /// <param name="repos"></param>
        public ProfessorController(IRepository repos)
        {
            _repos = repos;
        }

        /// <summary>
        /// Recupera todos os professores cadastrados
        /// </summary>
        /// <returns></returns>
        // GET: api/<ProfessorController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repos.GetAllProfessores());
        }

        /// <summary>
        /// Recupera o professor pelo ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET api/<ProfessorController>/5
        [HttpGet("byId/{id}")]
        public IActionResult GetById(int id)
        {
            var professor = _repos.GetProfessorById(id);

            if (professor == null)
                return BadRequest("Registros não encontrado!");

            return Ok(professor);
        }

        /// <summary>
        /// Recupera o professor pela Disciplina
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET api/<ProfessorController>/5
        [HttpGet("byDisciplinaId/{id}")]
        public IActionResult GetByDisciplinaId(int id)
        {
            var professor = _repos.GetAllProfessoresByDisciplinaId(id);

            if (professor == null)
                return BadRequest("Registro não encontrado!");

            return Ok(professor);
        }

        /// <summary>
        /// Recupera o professor pelo nome
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        // GET api/ByName?nome=Luiz
        [HttpGet("byName")]
        public IActionResult GetByName(string nome)
        {
            var professor = _repos.GetAllProfessores().FirstOrDefault(p => p.Nome.Contains(nome));

            if (professor == null)
                return BadRequest("Professor não encontrado!");

            return Ok(professor);
        }

        /// <summary>
        /// Adiciona um novo professor a base de dados
        /// </summary>
        /// <param name="professor"></param>
        /// <returns></returns>
        // POST api/<ProfessorController>
        [HttpPost]
        public IActionResult Post(Professor professor)
        {
            _repos.Add(professor);
            _repos.SaveChanges();
            return Ok(professor);
        }

        /// <summary>
        /// Atualiza o registro de professor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="professor"></param>
        /// <returns></returns>
        // PUT api/<ProfessorController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, Professor professor)
        {
            var registro = _repos.GetProfessorById(id);

            if (registro == null) 
                return BadRequest("Não foi possível atualizar o registro do professor!");

            _repos.Update(professor);
            _repos.SaveChanges();

            return Ok(professor);
        }

        /// <summary>
        /// Atualizar o registro de professor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="professor"></param>
        /// <returns></returns>
        // PATCH api/<ProfessorController>/5
        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Professor professor)
        {
            var registro = _repos.GetProfessorById(id);

            if (registro == null)
                return BadRequest("Não foi possível atualizar o registro do professor!");

            _repos.Update(professor);
            _repos.SaveChanges();

            return Ok(professor);
        }

        /// <summary>
        /// Excluir o registro de professor da base de dados
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // DELETE api/<ProfessorController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var prof = _repos.GetProfessorById(id);

            if (prof == null)
                return BadRequest("Não possivel <b>remover</b> o registro de professor!");

            _repos.Delete(prof);
            _repos.SaveChanges();

            return Ok();
        }
    }
}
