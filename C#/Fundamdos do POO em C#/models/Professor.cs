using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundamdos_do_POO_em_C_.models
{
  public class Professor : Person
  {
    public decimal Salario { get; set; }
    public override void toPresent()
    {
      Console.WriteLine($"Olá, meu nome é {Name}, tenho {Age}, sou um professor e ganho {Salario}");
    }
  }
}