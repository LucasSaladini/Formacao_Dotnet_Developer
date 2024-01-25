using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tipos_Especiais.Models
{
    public class Venda
    {
        public Venda(int id, string produto, decimal preco, DateTime saleDate)
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
        public decimal? Desconto { get; set; }
    }
}