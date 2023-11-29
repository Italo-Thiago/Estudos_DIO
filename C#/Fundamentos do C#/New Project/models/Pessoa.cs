using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace New_Project.models {
  public class Pessoa
  {
    public string Sobrenome;
    public string Nome;
    public Pessoa(string sobrenome, string nome)
    {
      Sobrenome = sobrenome;
      Nome = nome;
    }
    public string NomeCompleto => $"{Nome} {Sobrenome}";

  }
}