using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_em_C_.models
{
  public class Pessoa
  {
    public string Nome { get; set; }
    public int Idade {get; set; }
  
    public void Apresentar() {
      Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
    }
  }
}