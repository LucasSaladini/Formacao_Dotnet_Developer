using Classes_Abstratas_Interfaces.Interfaces;
using Classes_Abstratas_Interfaces.Models;

Corrente conta = new Corrente();
conta.Creditar(500);
conta.ExibirSaldo();

Pessoa p1 = new Pessoa("Lucas");
p1.Apresentar();
Aluno a1 = new Aluno("Eduardo");
a1.Apresentar();

Computador c = new Computador();
Console.WriteLine(c.ToString());

ICalculadora calc = new Calculadora();
Console.WriteLine(calc.Multiplicar(3, 9));