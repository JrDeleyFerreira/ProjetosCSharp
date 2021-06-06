using System;

namespace BanhoEmPet.PetShops
{
  public class ChowChawgas : PetShop
  {
    private const double precoCaoPequenoDDS = 30.0;
    private const double precoCaoGrandeDDS = 45.0;
    const string nome = "CHOWCHAWGAS";
    const int distancia = 800;

    public ChowChawgas(int qtdCaesPequenos, int qtdCaesGrandes, DateTime diaDaSemana)
      : base(qtdCaesPequenos, qtdCaesGrandes, diaDaSemana)
    {
      Nome = nome;
      Distancia = distancia;
    }

    public override void CalculaTotalDoBanho()
    {
      double totalBanhos;
      totalBanhos = CalcularValorTotalDosBanhos(precoCaoPequenoDDS, precoCaoGrandeDDS);
      RecebeValorFinal(totalBanhos);
    }
  }
}
