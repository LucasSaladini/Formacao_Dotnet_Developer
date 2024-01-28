using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca_Polimorfirmos.Models
{
    public class Aluno : Pessoa
    {
        public double Nota { get; set; }
        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade}, e sou um aluno nota {Nota}");
        }
    }
}