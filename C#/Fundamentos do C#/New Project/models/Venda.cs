using System;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace New_Project.models
{
  public class Venda
  {
    public int? Id { get; set; }
    [JsonPropertyName("Nome_Produto")]
    public string? Produto { get; set; }
    public decimal Preco { get; set; }
    public DateTime DataVenda { get; set; }
    public decimal? Desconto { get; set; }
    // public decimal Desconto { get; set; }
  }
}