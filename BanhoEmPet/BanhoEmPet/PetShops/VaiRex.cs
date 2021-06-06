using System;

namespace BanhoEmPet.PetShops
{
  public class VaiRex : PetShop
  {
    private const double precoCaoPequenoDDS = 15.0;
    private const double precoCaoGrandeDDS = 50.0;
    const string nome = "VAI REX";
    const int distancia = 1700;

    public VaiRex(int qtdCaesPequenos, int qtdCaesGrandes, DateTime diaDaSemana)
      : base(qtdCaesPequenos, qtdCaesGrandes, diaDaSemana)
    {
      Nome = nome;
      Distancia = distancia;
    }

    public override void CalculaTotalDoBanho()
    {
      var diaDaSemana = RetornaDiaLiteral(DiaDaSemana);
      double totalBanhos;

      if (diaDaSemana == DiaDaSemanaEnum.Saturday.ToString() || diaDaSemana == DiaDaSemanaEnum.Sunday.ToString())
      {
        var precoPequeno = precoCaoPequenoDDS + 5;
        var precoGrande = precoCaoGrandeDDS + 5;
        totalBanhos = CalcularValorTotalDosBanhos(precoPequeno, precoGrande);
      }
      else
      {
        totalBanhos = CalcularValorTotalDosBanhos(precoCaoPequenoDDS, precoCaoGrandeDDS);
      }

      RecebeValorFinal(totalBanhos);
    }
  }
}
