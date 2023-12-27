using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure.Data.Tables;
using Microsoft.AspNetCore.Mvc;
using WebApiAzureTable.models;

namespace WebApiAzureTable.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class ContatoController : ControllerBase
  {
    private readonly string _connectionString;
    private readonly string _tableName;

    public ContatoController(IConfiguration configuration)
    {
      _connectionString = configuration.GetValue<string>("SAConnectionString");
      _tableName = configuration.GetValue<string>("AzureTableName");
    }

    private TableClient GetTableClient()
    {
      var serviceClient = new TableServiceClient(_connectionString);
      var tableClient = serviceClient.GetTableClient(_tableName);

      tableClient.CreateIfNotExists();
      return tableClient;
    }

    [HttpPost]
    public IActionResult Criar(Contato contato)
    {
      var tableClient = GetTableClient();

      contato.RowKey = Guid.NewGuid().ToString();
      contato.PartitionKey = contato.RowKey;

      tableClient.UpsertEntity(contato);
      return Ok(contato);
    }

    [HttpPut("id")]
    public IActionResult Atualizar(string id, Contato contato)
    {
      var tableClient = GetTableClient();
      var contatoTable = tableClient.GetEntity<Contato>(id, id).Value;

      contatoTable.Nome = contato.Nome;
      contatoTable.Email = contato.Email;
      contatoTable.Telefone = contato.Telefone;

      tableClient.UpsertEntity(contatoTable);
      return Ok();
    }

    [HttpGet("Listar")]
    public IActionResult ObterTodos()
    {
      var tableClient = GetTableClient();
      var contatos = tableClient.Query<Contato>().ToList();
      return Ok(contatos);
    }

    [HttpGet("ObterPorNome/{nome}")]
    public IActionResult ObterPorNome(string nome)
    {
      var tableClient = GetTableClient();
      var contatos = tableClient.Query<Contato>(x => x.Nome == nome).ToList();
      return Ok(contatos);
    }

    [HttpDelete("{id}")]
    public IActionResult Deletar(string id)
    {
      var tableClient = GetTableClient();
      tableClient.DeleteEntity(id, id);
      return NoContent();
    }
  }
}