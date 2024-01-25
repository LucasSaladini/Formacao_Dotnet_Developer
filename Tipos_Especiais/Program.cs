using Tipos_Especiais.Models;
using Newtonsoft.Json;

bool? desejaReceberEmail = null;

if (desejaReceberEmail.HasValue && desejaReceberEmail.Value)
{
    Console.WriteLine("O usuário optou por receber email");
}
else
{
    Console.WriteLine("O usuário não respondeu ou optou por não receber email");
}

string conteudoArquivo = File.ReadAllText("Files/sales.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach (Venda venda in listaVenda)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, " +
                        $"Preço: {venda.Preco}, Data: {venda.SaleDate.ToString("dd/MM/yyyy HH:mm")}" +
                        $" {(venda.Desconto.HasValue ? $"Desconto de: {venda.Desconto}" : "")}");
}

var tipoAnonimo = new { Nome = "Lucas", Sobrenome = "Saladini", Altura = 1.83 };
Console.WriteLine("Nome: " + tipoAnonimo.Nome);
Console.WriteLine("Sobrenome: " + tipoAnonimo.Sobrenome);
Console.WriteLine("Altura: " + tipoAnonimo.Altura);

var listaAnonimo = listaVenda.Select(x => new { x.Produto, x.Preco });

foreach (var venda in listaAnonimo)
{
    Console.WriteLine($"Produto: {venda.Produto}, Preço: {venda.Preco}");
}

dynamic variavelDinamica = 4;
Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");
variavelDinamica = "Texto";
Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");
variavelDinamica = true;
Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

MeuArray<int> arrayInteiro = new MeuArray<int>();
arrayInteiro.AdicionarElementoArray(30);
Console.WriteLine(arrayInteiro[0]);

MeuArray<string> arrayString = new MeuArray<string>();
arrayString.AdicionarElementoArray("Teste");
Console.WriteLine(arrayString[0]);

int numero = 15;
bool par = false;

par = numero.EPar();

string mensagem = "O número " + numero + " " + "é " + (par ? "par" : "ímpar");
Console.WriteLine(mensagem);