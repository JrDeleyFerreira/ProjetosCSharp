using System.Collections.Generic;
using System.Linq;

namespace AluraFilmesEntity.Model
{
  public enum ClassificacaoIndicativa
  {
    Livre,
    MaiorQue10,
    MaiorQue12,
    MaiorQue14,
    MaiorQue18
  }

  public static class ClassificacaoIndicativaExtensions
  {
    private static Dictionary<string, ClassificacaoIndicativa> mapa = new Dictionary<string, ClassificacaoIndicativa>
    {
      { "G",     ClassificacaoIndicativa.Livre },
      { "PG",    ClassificacaoIndicativa.MaiorQue10 },
      { "PG-13", ClassificacaoIndicativa.MaiorQue12 },
      { "R",     ClassificacaoIndicativa.MaiorQue14 },
      { "NC-17", ClassificacaoIndicativa.MaiorQue18 }
    };

    public static string EnumParaString(this ClassificacaoIndicativa valor) =>
       mapa.First(pp => pp.Value == valor).Key;

    public static ClassificacaoIndicativa TextoParaEnum(this string texto) =>
       mapa.First(pp => pp.Key == texto).Value;

  }
}
