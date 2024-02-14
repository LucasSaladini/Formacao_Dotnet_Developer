using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Desafio_API_MVC.Models;

namespace Desafio_API_MVC.Context
{
    public class OrganizerContext : DbContext
    {
        public OrganizerContext(DbContextOptions<OrganizerContext> options) : base(options)
        {

        }

        public DbSet<TodoTask> TodoTasks { get; set; }
    }
}