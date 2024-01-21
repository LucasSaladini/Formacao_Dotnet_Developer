using Nuget_Serializar_Atributos.Models;
using Newtonsoft.Json;

DateTime currentDate = DateTime.Now;

// List<Sales> salesList = new List<Sales>();

// // Srialização
// Sales v1 = new Sales(1, "Material de escritório", 25.00M, currentDate);
// Sales v2 = new Sales(2, "Licença de Software", 110.00M, currentDate);

// salesList.Add(v1);
// salesList.Add(v2);

// string serialized = JsonConvert.SerializeObject(salesList, Formatting.Indented);

// File.WriteAllText("Files/sales.json", serialized);

// Console.WriteLine(serialized);

// Deserialização
string conteudoArquivo = File.ReadAllText("Files/sales.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach (Venda venda in listaVenda)
{
    Console.WriteLine($"Id: {venda.Id}, Produto:{venda.Produto}, " +
        $"Preço {venda.Preco}, Data: {venda.SaleDate.ToString("dd/MM/yyyy HH:mm")}");
}