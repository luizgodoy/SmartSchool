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
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorController : ControllerBase
    {
        private readonly IRepository _repos;

        public ProfessorController(IRepository repos)
        {
            _repos = repos;
        }

        // GET: api/<ProfessorController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repos.GetAllProfessores());
        }

        // GET api/<ProfessorController>/5
        [HttpGet("byId/{id}")]
        public IActionResult GetById(int id)
        {
            var professor = _repos.GetProfessorById(id);

            if (professor == null)
                return BadRequest("Registros não encontrado!");

            return Ok(professor);
        }

        // GET api/<ProfessorController>/5
        [HttpGet("byDisciplinaId/{id}")]
        public IActionResult GetByDisciplinaId(int id)
        {
            var professor = _repos.GetAllProfessoresByDisciplinaId(id);

            if (professor == null)
                return BadRequest("Registro não encontrado!");

            return Ok(professor);
        }

        // GET api/ByName?nome=Luiz
        [HttpGet("byName")]
        public IActionResult GetByName(string nome)
        {
            var professor = _repos.GetAllProfessores().FirstOrDefault(p => p.Nome.Contains(nome));

            if (professor == null)
                return BadRequest("Professor não encontrado!");

            return Ok(professor);
        }

        // POST api/<ProfessorController>
        [HttpPost]
        public IActionResult Post(Professor professor)
        {
            _repos.Add(professor);
            _repos.SaveChanges();
            return Ok(professor);
        }

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

        // PUT api/<ProfessorController>/5
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
