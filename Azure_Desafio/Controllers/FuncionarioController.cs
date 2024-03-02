using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure_Desafio.Context;
using Azure_Desafio.Models;
using Microsoft.AspNetCore.Mvc;

namespace Azure_Desafio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FuncionarioController : ControllerBase
    {
        private readonly RHContext _context;

        public FuncionarioController(RHContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var funcionario = _context.Funcionarios.Find(id);

            if (funcionario == null)
                return NotFound();

            return Ok(funcionario);
        }

        [HttpPost]
        public IActionResult Create(Funcionario funcionario)
        {
            _context.Funcionarios.Add(funcionario);
            _context.SaveChanges();

            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Funcionario funcionario)
        {
            var funcionariosBase = _context.Funcionarios.Find(id);

            if (funcionariosBase == null)
                return NotFound();

            funcionariosBase.Nome = funcionario.Nome;
            funcionariosBase.Endereco = funcionario.Endereco;
            funcionariosBase.Ramal = funcionario.Ramal;
            funcionariosBase.EmailProfissional = funcionario.EmailProfissional;
            funcionariosBase.Departamento = funcionario.Departamento;
            funcionariosBase.Salario = funcionario.Salario;
            funcionariosBase.DataAdmissao = funcionario.DataAdmissao;

            _context.SaveChanges();

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var funcionariosBase = _context.Funcionarios.Find(id);

            if (funcionariosBase == null)
                return NotFound();

            _context.SaveChanges();

            return Ok();
        }
    }
}