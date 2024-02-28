using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microfsoft.ApsNetCore.Mvc;

namespace Azure_Table.Controllers
{
    [ApiController]
    [Route("(controller)")]
    public class ContatoController : ControllerBase
    {
        private readonly string _connectionString;
        private readonly string _tableName;

        public ContatoController(IConfiguration configuration)
        {
            _connectionString = configuration.GetValue<string>("SAConnectionString");
            _tableName = configuration.GetValue<string>("AzureTableName");
        }
    }
}