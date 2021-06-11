using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartSchool.API.Data;
using SmartSchool.API.Dtos;
using SmartSchool.API.Helpers;
using SmartSchool.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SmartSchool.API.Controllers
{
    /// <summary>
    /// Controller de Aluno
    /// </summary>
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class AlunoController : ControllerBase
    {
        private readonly IRepository _repos;
        private readonly IMapper _mapper;

        /// <summary>
        /// Construtor principal
        /// </summary>
        /// <param name="repos"></param>
        /// <param name="mapper"></param>
        public AlunoController(IRepository repos, IMapper mapper)
        {
            _repos = repos;
            _mapper = mapper;
        }        

        /// <summary>
        /// Recupera todos os alunos
        /// </summary>
        /// <returns></returns>
        // GET: api/<AlunoController>
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] PageParams pageParams)
        {
            var alunos = await _repos.GetAllAlunosAsync(pageParams, true);
            var alunosResult = _mapper.Map<IEnumerable<AlunoDto>>(alunos);

            Response.AddPagination(alunos.CurrentPage, alunos.PageSize, alunos.TotalCount, alunos.TotalPages);

            return Ok(alunosResult);
        }


        /// <summary>
        /// Recupera um aluno específico por ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET api/<AlunoController>/5
        [HttpGet("byId/{id}")]
        public IActionResult GetById(int id)
        {
            var aluno = _repos.GetAlunoById(id, true);

            if (aluno == null)
                return BadRequest("Registro não encontrado!");

            return Ok(aluno);
        }

        /// <summary>
        /// Recupera todos os alunos de um disciplina ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET api/<AlunoController>/5
        [HttpGet("byDisciplinaId/{id}")]
        public IActionResult GetByDisciplinaId(int id)
        {
            var aluno = _repos.GetAllAlunosByDisciplinaId(id, true);

            if (aluno == null)
                return BadRequest("Registro não encontrado!");

            return Ok(aluno);
        }

        /// <summary>
        /// Recupera um aluno por nome, exatamente igual a string informada
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="sobrenome"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Adiciona um novo aluno
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Atualiza o registro de aluno
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Atualiza uma informação de aluno
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Exclui um aluno da base de dados
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
