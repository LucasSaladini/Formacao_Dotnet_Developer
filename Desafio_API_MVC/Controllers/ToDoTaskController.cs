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
            var todoTasks = _context.TodoTasks.ToList();
            return View(todoTasks);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult CreateTask(TodoTask task)
        {
            if(ModelState.IsValid)
            {
                _context.TodoTasks.Add(task);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(task);
        }

        public IActionResult Delete(int id)
        {
            var task = _context.TodoTasks.Find(id);

            if(task == null) 
            {
                return RedirectToAction(nameof(Index));
            }

            return View(task);
        }

        [HttpPost]
        public IActionResult Delete(TodoTask task)
        {
            var taskDatabase = _context.TodoTasks.Find(task.Id);
            _context.TodoTasks.Remove(taskDatabase);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}