using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Frontend_com_ASPNET_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace Frontend_com_ASPNET_MVC.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {

        }

        public DbSet<Contato> Contatos { get; set; }
    }
}