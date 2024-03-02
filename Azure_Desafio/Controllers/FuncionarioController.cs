using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure_Desafio.Context;
using Azure_Desafio.Models;
using Microsoft.AspNetCore.Mvc;

namespace Azure_Desafio.Controllers
{
    public class FuncionarioController : Controller
    {
        private readonly RHContext _context;

        public FuncionarioController(RHContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var funcionarios = _context.Funcionarios.ToList();

            return View(funcionarios);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Funcionario funcionario)
        {
            if (ModelState.IsValid)
            {
                _context.Funcionarios.Add(funcionario);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(funcionario);
        }

        public IActionResult Update(int id)
        {
            var funcionario = _context.Funcionarios.Find(id);

            if (funcionario == null)
                return NotFound();

            return View(funcionario);
        }

        [HttpPost]
        public IActionResult Update(Funcionario funcionario)
        {
            var funcionariosBase = _context.Funcionarios.Find(funcionario.Id);

            if (funcionariosBase == null)
                return NotFound();

            funcionariosBase.Nome = funcionario.Nome;
            funcionariosBase.Endereco = funcionario.Endereco;
            funcionariosBase.Ramal = funcionario.Ramal;
            funcionariosBase.EmailProfissional = funcionario.EmailProfissional;
            funcionariosBase.Departamento = funcionario.Departamento;
            funcionariosBase.Salario = funcionario.Salario;
            funcionariosBase.DataAdmissao = funcionario.DataAdmissao;

            _context.Funcionarios.Update(funcionariosBase);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult Delete(Funcionario funcionario)
        {
            var funcionariosBase = _context.Funcionarios.Find(funcionario.Id);

            if (funcionariosBase == null)
                return NotFound();

            _context.SaveChanges();

            return Ok();
        }
    }
}