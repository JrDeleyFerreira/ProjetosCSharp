using BanhoEmPet.PetShops;
using System.Windows.Forms;

namespace BanhoEmPet
{
  public class ComparadorDeOrcamentos
  {
    public ComparadorDeOrcamentos() {  }

    public void OrcamentoDosBanhosNosPets(VaiRex vaiRex, MeuCaninoFeliz meuCanino, ChowChawgas chowChaw)
    {
      var comparacao = vaiRex.TotalizadorDosBanhos.CompareTo(meuCanino.TotalizadorDosBanhos);

      if (comparacao == -1)
      {
        var comparacao1 = vaiRex.TotalizadorDosBanhos.CompareTo(chowChaw.TotalizadorDosBanhos);
        ResultadoMenorValorBanho(vaiRex, chowChaw, comparacao1);
      }

      if (comparacao == 1)
      {
        var comparacao1 = meuCanino.TotalizadorDosBanhos.CompareTo(chowChaw.TotalizadorDosBanhos);
        ResultadoMenorValorBanho(meuCanino, chowChaw, comparacao1);
      }

      if (comparacao == 0)
      {
        var comparacao1 = meuCanino.TotalizadorDosBanhos.CompareTo(chowChaw.TotalizadorDosBanhos);
        ResultadoMenorValorBanho(vaiRex, chowChaw, comparacao1);
      }
    }

    private void ResultadoMenorValorBanho(PetShop petShop1, PetShop petShop2, int comparacao1)
    {
      if (comparacao1 == -1)
        MessageBox.Show(string.Format(Properties.Resources.TextoFinalizacaoOrcamento, petShop1.Nome,
          petShop1.TotalizadorDosBanhos));

      if (comparacao1 == 1)
        MessageBox.Show(string.Format(Properties.Resources.TextoFinalizacaoOrcamento, petShop2.Nome,
          petShop2.TotalizadorDosBanhos));

      if (comparacao1 == 0)
      {
        var comparaDistancia = petShop1.Distancia.CompareTo(petShop2.Distancia);

        if (comparaDistancia == -1)
          MessageBox.Show(string.Format(Properties.Resources.TextoFinalizacaoOrcamento, petShop1.Nome,
            petShop1.TotalizadorDosBanhos));

        MessageBox.Show(string.Format(Properties.Resources.TextoFinalizacaoOrcamento, petShop2.Nome,
          petShop2.TotalizadorDosBanhos));
      }
    }
  }
}