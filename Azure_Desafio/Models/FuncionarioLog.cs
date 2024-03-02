using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Azure_Desafio.Models
{
    public class FuncionarioLog : Funcionario
    {
        public FuncionarioLog() { }

        public TipoAcao TipoAcao { get; set; }
        public string JSON { get; set; }
        public string PartitionKey { get; set; }
        public string RowKey { get; set; }
        public DateTimeOffset Timestamp { get; set; }
    }
}