using System;

namespace BanhoEmPet.PetShops
{
  /// <summary>
  /// Classe abstrata de Pet Shop
  /// </summary>
  public abstract class PetShop
  {
    public int QtdCaesPequenos { get; }
    public int QtdCaesGrandes { get; }
    public DateTime DiaDaSemana { get; }
    public double TotalizadorDosBanhos { get; protected set; }
    public string Nome { get; protected set; }
    public int Distancia { get; protected set; }

    protected PetShop(int qtdCaesPequenos, int qtdCaesGrandes, DateTime diaDaSemana)
    {
      QtdCaesPequenos = qtdCaesPequenos;
      QtdCaesGrandes = qtdCaesGrandes;
      DiaDaSemana = diaDaSemana;
    }

    protected PetShop() { }

    public abstract void CalculaTotalDoBanho();

    protected string RetornaDiaLiteral(DateTime dataValue)
    {
      var dayOfWeek = dataValue.DayOfWeek.ToString();
      return dayOfWeek;
    }

    protected double CalcularValorTotalDosBanhos(double precoPequeno, double precoGrande)
    {
      var somaCaesPequenos = QtdCaesPequenos * precoPequeno;
      var somaCaesGrandes = QtdCaesGrandes * precoGrande;

      return somaCaesPequenos + somaCaesGrandes;
    }

    protected enum DiaDaSemanaEnum
    {
      Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
    }

    protected void RecebeValorFinal(double valorFinal)
    {
      TotalizadorDosBanhos = valorFinal;
    }
  }
}
