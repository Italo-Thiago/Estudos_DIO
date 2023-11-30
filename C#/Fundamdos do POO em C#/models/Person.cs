using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundamdos_do_POO_em_C_.models
{
  public class Person
  {
    public string Name { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }

    public virtual void toPresent()
    {
      Console.WriteLine($"Olá, meu nome é {Name} e tenho {Age} anos!");
    }
  }
}