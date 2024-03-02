using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure_Desafio.Models;
using Microsoft.EntityFrameworkCore;

namespace Azure_Desafio.Context
{
    public class RHContext : DbContext
    {
        public RHContext(DbContextOptions<RHContext> options) : base(options)
        {

        }

        public DbSet<Funcionario> Funcionarios { get; set; }
    }
}