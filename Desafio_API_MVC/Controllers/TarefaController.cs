using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_API_MVC.Controllers
{
    public class TarefaController : ControllerBase
    {
        private readonly OrganizerContext _context;

        public TaskController(OrganizerContext context)
        {
            _context = context;
        }

        public IActionResult GetById(int id)
        {

        }

        public IActionResult GetAll()
        {

        }

        public IActionResult GetByTitle(string title)
        {

        }

        public IActionResult GetByDate(DateTime date)
        {

        }

        public IActionResult GetByStatus(EnumTaskStatus status)
        {

        }

        public IActionResult Create(Task task)
        {

        }

        public IActionResult Update(int id, Task task)
        {

        }

        public IActionResult Delete(int id)
        {

        }
    }
}