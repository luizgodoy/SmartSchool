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
        private readonly SmartContext _context;

        public ProfessorController(SmartContext context)
        {
            this._context = context;
        }

        // GET: api/<ProfessorController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Professores);
        }

        // GET api/<ProfessorController>/5
        [HttpGet("byId/{id}")]
        public IActionResult GetById(int id)
        {
            var professor = _context.Professores.FirstOrDefault(p => p.Id == id);

            if (professor == null)
                return BadRequest("Professor não encontrado!");

            return Ok(professor);
        }

        // GET api/ByName?nome=Luiz
        [HttpGet("byName")]
        public IActionResult GetByName(string nome)
        {
            var professor = _context.Professores.FirstOrDefault(p => p.Nome.Contains(nome));

            if (professor == null)
                return BadRequest("Professor não encontrado!");

            return Ok(professor);
        }

        // POST api/<ProfessorController>
        [HttpPost]
        public IActionResult Post(Professor professor)
        {
            _context.Add(professor);
            _context.SaveChanges();
            return Ok(professor);
        }

        // PUT api/<ProfessorController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, Professor professor)
        {
            var registro = _context.Professores.AsNoTracking().FirstOrDefault(a => a.Id == id);

            if (registro == null) 
                return BadRequest("Não foi possível atualizar o registro do professor!");

            _context.Update(professor);
            _context.SaveChanges();
            return Ok(professor);
        }

        // PUT api/<ProfessorController>/5
        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Professor professor)
        {
            var registro = _context.Professores.AsNoTracking().FirstOrDefault(a => a.Id == id);

            if (registro == null)
                return BadRequest("Não foi possível atualizar o registro do professor!");

            _context.Update(professor);
            _context.SaveChanges();
            return Ok(professor);
        }

        // DELETE api/<ProfessorController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var prof = _context.Professores.FirstOrDefault(p => p.Id == id);

            if (prof == null)
                return BadRequest("Não possivel <b>remover</b> o registro de professor!");

            _context.Remove(prof);
            _context.SaveChanges();
            return Ok();
        }
    }
}
