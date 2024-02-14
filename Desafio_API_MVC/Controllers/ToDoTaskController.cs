using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Desafio_API_MVC.Context;
using Desafio_API_MVC.Models;

namespace Desafio_API_MVC.Controllers
{
    public class ToDoTaskController : Controller
    {
        private readonly OrganizerContext _context;

        public ToDoTaskController(OrganizerContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // var todoTasks = _context.TodoTasks.ToList();
            return View();
        }
    }
}