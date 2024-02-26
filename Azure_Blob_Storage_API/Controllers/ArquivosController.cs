using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;

namespace Azure_Blob_Storage_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArquivosController : ControllerBase
    {
        private readonly string _connectionString;
        private readonly string _containerName;

        public ArquivosController(IConfiguration configuration)
        {
            _connectionString = configuration.GetValue<string>("BlobConnectionString");
            _containerName = configuration.GetValue<string>("BlobContainerName");
        }

        [HttpPost("Upload")]
        public IActionResult UploadArquivo(IFormFile arquivo)
        {
            //BLOB = Binary Large Object
            BlobContainerClient container = new(_connectionString, _containerName);
            BlobClient blob = container.GetBlobClient(arquivo.FileName);

            using var data = arquivo.OpenReadStream();
            blob.Upload(data, new BlobUploadOptions
            {
                HttpHeaders = new BlobHttpHeaders { ContentType = arquivo.ContentType }
            });

            return Ok(blob.Uri.ToString());
        }

        [HttpGet("Download/(nome)")]
        public IActionResult DownloadArquivo(string nome)
        {
            BlobContainerClient container = new(_connectionString, _containerName);
            BlobClient blob = container.GetBlobClient(nome);

            if (blob.Exists())
                return BadRequest();
            
            var retorno = blob.DownloadContent();
            return File(retorno.Value.Content.ToArray(), retorno.Value.Details.ContentType, blob.Name);
        }
    }
}