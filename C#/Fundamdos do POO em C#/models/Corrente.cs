using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundamdos_do_POO_em_C_.models
{
  public class Corrente : Conta
  {
    public override void Creditar(decimal valor)
    {
      saldo += valor;
    }
  }
}