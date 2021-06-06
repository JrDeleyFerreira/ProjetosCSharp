using System;

namespace BanhoEmPet.PetShops
{
  public class MeuCaninoFeliz : PetShop
  {
    private const double precoCaoPequenoDDS = 20.0;
    private const double precoCaoGrandeDDS = 40.0;
    const string nome = "MEU CANINO FELIZ";
    const int distancia = 2000;

    public MeuCaninoFeliz(int qtdCaesPequenos, int qtdCaesGrandes, DateTime diaDaSemana)
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
        var precoPequeno = precoCaoPequenoDDS + (precoCaoPequenoDDS * 0.2);
        var precoGrande = precoCaoGrandeDDS + (precoCaoGrandeDDS * 0.2);
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
