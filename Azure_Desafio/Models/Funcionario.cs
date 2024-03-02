using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Azure_Desafio.Models
{
    public class Funcionario
    {
        public Funcionario() { }

        public Funcionario(int id, string nome, string endereco, string ramal, string emailProfissional, string departamento, decimal salario, DateTime dataAdmissao)
        {
            this.Id = id;
            this.Nome = nome;
            this.Endereco = endereco;
            this.Ramal = ramal;
            this.EmailProfissional = emailProfissional;
            this.Departamento = departamento;
            this.Salario = salario;
            this.DataAdmissao = dataAdmissao;
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Ramal { get; set; }
        public string EmailProfissional { get; set; }
        public string Departamento { get; set; }
        public decimal Salario { get; set; }
        public DateTimeOffset? DataAdmissao { get; set; }
    }
}