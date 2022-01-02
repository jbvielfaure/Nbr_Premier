using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nbrPremier.Outils
{
  public class NombrePremier
  {
    public static int nbrPremier(int nombre)
    {
      int i;
      for (i = 2; i * i <= nombre; i++)
      {
        if (nombre % i == 0) return 0;
      }
      return 1;
    }
  }
}
