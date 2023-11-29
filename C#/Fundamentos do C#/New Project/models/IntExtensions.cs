using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace New_Project.models
{
  public static class IntExtensions
  {
    public static bool EhPar(this int numero) {
      return numero % 2 == 0;
    }
  }
}