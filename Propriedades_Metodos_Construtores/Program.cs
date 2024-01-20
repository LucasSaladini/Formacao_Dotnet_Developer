using Propriedades_Metodos_Construtores.Models;
using System.Globalization;

Pessoa p1 = new Pessoa(nome: "Lucas", sobrenome: "Saladini");

Pessoa p2 = new Pessoa(nome: "Leonardo", sobrenome: "Neves Queiroz");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

decimal valorMonetario = 1582.40M;
Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

double porcentagem = .3421;
Console.WriteLine(porcentagem.ToString("P2"));

DateTime data = DateTime.Now;
Console.WriteLine(data);
Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));
Console.WriteLine(data.ToShortDateString());
Console.WriteLine(data.ToShortTimeString());


string dataString = "2022-04-17 18:00";

bool success = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm",
                        CultureInfo.InvariantCulture,
                        DateTimeStyles.None,
                        out DateTime data2);

if (success)
{
    Console.WriteLine($"Conversão com sucesso! Data: {data2}");
}
else
{
    Console.WriteLine($"{dataString} não é uma data válida");
}


// p1.Idade = 30;
// p1.Apresentar();