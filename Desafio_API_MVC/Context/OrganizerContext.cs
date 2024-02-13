using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_API_MVC.Context
{
    public class OrganizerContext : DbContext
    {
        public OrganizerContext(DbContextOptions<OrganizerContext> option) : base(options)
        {

        }

        public DbSet<Task> Tasks { get; set; }
    }
}