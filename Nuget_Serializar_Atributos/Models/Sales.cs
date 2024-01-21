using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nuget_Serializar_Atributos.Models
{
    public class Sales
    {
        public Sales(int id, string produto, decimal preco, DateTime saleDate)
        {
            Id = id;
            Produto = produto;
            Preco = preco;
            SaleDate = saleDate;
        }
        public int Id { get; set; }
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime SaleDate { get; set; }
    }
}