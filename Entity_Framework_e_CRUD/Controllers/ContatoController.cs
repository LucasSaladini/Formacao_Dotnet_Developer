using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity_Framework_e_CRUD.Context;
using Entity_Framework_e_CRUD.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Entity_Framework_e_CRUD.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class ContatoController : ControllerBase
    {
        private readonly AgendaContext _context;
        public ContatoController(AgendaContext context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult Create(Contato contato)
        {
            _context.Add(contato);
            _context.SaveChanges();
            return Ok(contato);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var contact = _context.Contatos.Find(id);

            if(contact == null)
                return NotFound();

            return Ok(contact);
        }
    }
}