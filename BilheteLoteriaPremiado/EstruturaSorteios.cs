using System;
using System.Collections.Generic;
using System.Linq;

namespace BilhetePremiado
{
  public class EstruturaSorteios
  {
    public List<int> SorteioDoDia { get; protected set; }
    public Random NumRandomico { get; protected set; }
    public int QuantidadeDezenas { get; }
    public int QuantidadeSorteios { get; }

    public EstruturaSorteios(int quantidadeDezenas, int quantidadeSorteios)
    {
      SorteioDoDia = new List<int>();
      NumRandomico = new Random();

      QuantidadeDezenas = quantidadeDezenas;
      QuantidadeSorteios = quantidadeSorteios;
    }

    public void RealizaSorteios()
    {
      for (int indice = 0; indice < QuantidadeDezenas; indice++)
        ValidaDezenaSorteada();
    }

    private void ValidaDezenaSorteada()
    {
      var dezenaSorteada = NumRandomico.Next(1, 60);
      var existeIgualdade = false;

      if (SorteioDoDia.Count == 0)
        SorteioDoDia.Add(dezenaSorteada);
      else
      {
        var cartelaIncompleta = SorteioDoDia.Where(item => item != 0).ToList();

        foreach (var item in cartelaIncompleta)
        {
          if (item == dezenaSorteada)
            existeIgualdade = true;
        }

        if (!existeIgualdade)
          SorteioDoDia.Add(dezenaSorteada);
        else
          ValidaDezenaSorteada();
      }
    }

    public void ImprimeSorteio()
    {
      foreach (var item in SorteioDoDia)
        Console.Write(item + " ");
    }

  }
}
