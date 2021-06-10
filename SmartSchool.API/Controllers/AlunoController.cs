using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartSchool.API.Data;
using SmartSchool.API.Dtos;
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
    public class AlunoController : ControllerBase
    {
        private readonly IRepository _repos;
        private readonly IMapper _mapper;

        public AlunoController(IRepository repos, IMapper mapper)
        {
            _repos = repos;
            _mapper = mapper;
        }        
        
        // GET: api/<AlunoController>
        [HttpGet]
        public IActionResult Get()
        {
            var alunos = _repos.GetAllAlunos(true);
            return Ok(_mapper.Map<IEnumerable<AlunoDto>>(alunos));
        }

        // GET api/<AlunoController>/5
        [HttpGet("byId/{id}")]
        public IActionResult GetById(int id)
        {
            var aluno = _repos.GetAlunoById(id, true);

            if (aluno == null)
                return BadRequest("Registro não encontrado!");

            return Ok(aluno);
        }

        // GET api/<AlunoController>/5
        [HttpGet("byId/{id}")]
        public IActionResult GetByDisciplinaId(int id)
        {
            var aluno = _repos.GetAllAlunosByDisciplinaId(id, true);

            if (aluno == null)
                return BadRequest("Registro não encontrado!");

            return Ok(aluno);
        }

        // GET api/<AlunoController>/5
        [HttpGet("ByName")]
        public IActionResult GetByName(string nome, string sobrenome)
        {
            var aluno = _repos.GetAllAlunos(false).FirstOrDefault(a => a.Nome.Contains(nome) && a.Sobrenome.Contains(sobrenome));

            if (aluno == null)
                return BadRequest("Aluno não encontrado!");

            var alunoDto = _mapper.Map<AlunoDto>(aluno);
            return Ok(alunoDto);
        }

        // POST api/<AlunoController>
        [HttpPost]
        public IActionResult Post(AlunoDto model)
        {
            var aluno = _mapper.Map<Aluno>(model);
            _repos.Add(aluno);

            if(_repos.SaveChanges())
                return Created($"/api/aluno/{model.Id}", _mapper.Map<AlunoDto>(aluno));

            return BadRequest("Registro não cadastrado!");
        }

        // PUT api/<AlunoController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, AlunoDto model)
        {
            var aluno = _repos.GetAlunoById(id);
            
            if (aluno == null) 
                return BadRequest("Não foi possível atualizar o registro!");

            _mapper.Map(model, aluno);
            _repos.Update(aluno);

            if (_repos.SaveChanges())
                return Created($"/api/aluno/{model.Id}", _mapper.Map<AlunoDto>(aluno));

            return BadRequest("Registro não atualizado!");
        }

        // PATCH api/<AlunoController>/5
        [HttpPatch("{id}")]
        public IActionResult Patch(int id, AlunoDto model)
        {
            var aluno = _repos.GetAlunoById(id);
            
            if (aluno == null) 
                return BadRequest("Não foi possível atualizar o registro!");

            _mapper.Map(model, aluno);
            _repos.Update(aluno);

            if (_repos.SaveChanges())
                return Created($"/api/aluno/{model.Id}", _mapper.Map<AlunoDto>(aluno));

            return BadRequest("Registro não atualizado!");
        }

        // DELETE api/<AlunoController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var aluno = _repos.GetAlunoById(id);

            if (aluno == null)
                return BadRequest("Não foi possível excluir o registro!");

            _repos.Delete(aluno);

            if (_repos.SaveChanges())
                return Ok();

            return BadRequest("Registro não excluído!");
        }
    }
}
