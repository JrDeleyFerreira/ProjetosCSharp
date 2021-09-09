using System;
using System.Collections.Generic;

namespace BilheteLoteriaPremiado
{
  public class ContagemMaisSorteados
  {
    public int[] CartelaCompleta { get; protected set; }

    public ContagemMaisSorteados() => CartelaCompleta = new int[60];

    public void SalvaTodosOsSorteios(List<int> resultado)
    {
      foreach (var item in resultado)
        CartelaCompleta[item - 1] += 1;
    }

    public List<int> RecuperaMaisSorteados(int qtdeDezenas)
    {
      var result = new List<int>();
      var maior = 0;

      for (int dezena = 0; dezena < qtdeDezenas; dezena++)
      {
        var atual = 0;
        for (int indice = 0; indice < CartelaCompleta.Length; indice++)
        {
          if (CartelaCompleta[indice] == 0)
            continue;

          if (CartelaCompleta[indice] > atual)
          {
            atual = CartelaCompleta[indice];
            maior = indice;
          }
        }

        CartelaCompleta[maior] = 0;
        maior += 1;
        result.Add(maior);
      }

      return result;
    }

  }
}
