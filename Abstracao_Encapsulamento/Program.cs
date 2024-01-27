using Abstracao_Encapsulamento.Models;

Pessoa p1 = new Pessoa();

p1.Nome = "Lucas";
p1.Idade = 30;
p1.Apresentar();

ContaCorrente c1 = new ContaCorrente(123, 1000);
c1.ExibirSaldo();
c1.Sacar(5000);
c1.ExibirSaldo();