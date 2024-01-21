using System.ComponentModel;
using Tuplas_Operador_Ternario_Desconstrucao.Models;

(int Id, string Nome, string Sobrenome) tuple = (1, "Lucas", "Saladini");
ValueTuple<int, string, string> tuple2 = (2, "Patricia", "Saladini");
var tuple3 = Tuple.Create(3, "Amanda", "Rocha");

Console.WriteLine($"ID: {tuple.Id}");
Console.WriteLine($"Nome: {tuple.Nome}");
Console.WriteLine($"Sobrenome: {tuple.Sobrenome}");

Console.WriteLine($"ID: {tuple2.Item1}");
Console.WriteLine($"Nome: {tuple2.Item2}");
Console.WriteLine($"Sobrenome: {tuple2.Item3}");

Console.WriteLine($"ID: {tuple3.Item1}");
Console.WriteLine($"Nome: {tuple3.Item2}");
Console.WriteLine($"Sobrenome: {tuple3.Item3}");

Console.WriteLine("Lendo arquivo");
LeituraArquivo file = new LeituraArquivo();
var (success, fileLines, _) = file.LerArquivo("Files/leitura.txt");

if (success)
{
    // Console.WriteLine("Quantidade linhas do arquivo: " + linesQuantity);
    foreach (string line in fileLines)
    {
        Console.WriteLine(line);
    }
}
else
{
    Console.WriteLine("Não foi possível ler o arquivo");
}


// Deconstruct
Pessoa p1 = new Pessoa("Lucas", "Saladini");

(string nome, string sobrenome) = p1;

Console.WriteLine($"{nome} {sobrenome}");

// If ternário
int number = 20;
bool ePar = false;

ePar = number == 0;

Console.WriteLine($"O número {number} é " + (ePar ? "par" : "ímpar"));