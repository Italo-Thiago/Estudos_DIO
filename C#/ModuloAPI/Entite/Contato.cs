using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloAPI.Entities
{
  public class Contato
  {
    public int Id { get; set; }
    public required string Nome { get; set; }
    public required string Telefone { get; set; }
    public bool Ativo { get; set; }
  }
}