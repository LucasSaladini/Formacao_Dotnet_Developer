using Excecoes_e_Colecoes.Models;

try
{
    string[] lines = File.ReadAllLines("files/leitura.txt");

    foreach (string line in lines)
    {
        Console.WriteLine(line);
    }
}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
}
catch (DirectoryNotFoundException ex)
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta  não encontrado"
        + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine($"Ocorreu uma exceção genérica. Arquivo não encontrado. {ex.Message}");
}
finally
{
    Console.WriteLine("Chegou até aqui");
}

new ExemploExcecao().Metodo1();

Queue<int> queue = new Queue<int>();

queue.Enqueue(2);
queue.Enqueue(4);
queue.Enqueue(6);
queue.Enqueue(8);

Console.WriteLine("Fila");
foreach (int item in queue)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento: {queue.Dequeue()}");
queue.Enqueue(10);

foreach (int item in queue)
{
    Console.WriteLine(item);
}

Stack<int> stack = new Stack<int>();

stack.Push(4);
stack.Push(6);
stack.Push(8);
stack.Push(10);

Console.WriteLine("Pilha");
foreach (int item in stack)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento do topo: {stack.Pop()}");

stack.Push(20);

foreach (int item in stack)
{
    Console.WriteLine(item);
}

Dictionary<string, string> states = new Dictionary<string, string>();

states.Add("SP", "São Paulo");
states.Add("BA", "Bahia");
states.Add("MG", "Minas Gerais");

Console.WriteLine("Dictionary");
foreach (KeyValuePair<string, string> item in states)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

states.Remove("BA");

Console.WriteLine("Removendo um valor");
foreach (var item in states)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

states["SP"] = "São Paulo - valor alterado";

Console.WriteLine("Alterando um valor");

foreach (var item in states)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

string key = "SP";
Console.WriteLine($"Verificando o elemento: {key}");

if (states.ContainsKey(key))
{
    Console.WriteLine($"Valor existente: {key}");
}
else
{
    Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {key}");
}

Console.WriteLine(states["SP"]);