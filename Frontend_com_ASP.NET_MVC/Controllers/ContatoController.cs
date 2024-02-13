using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Frontend_com_ASPNET_MVC.Context;

namespace Frontend_com_ASPNET_MVC.Controllers
{
    public class ContatoController : Controller
    {
        private readonly AgendaContext _context;
        
        public ContatoController(AgendaContext context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {
            var contatos = _context.Contatos.ToList();
            return View(contatos);
        }

        public IActionResult Criar()
        {
            return View();
        }
    }
}