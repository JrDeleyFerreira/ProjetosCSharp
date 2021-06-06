using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BanhoEmPet.PetShops;
using BanhoEmPet;

namespace BanhoEmPetTest
{
  [TestClass]
  public class OrcamentoDosBanhos
  {
    #region Variáveis e Inicializadores
    private DateTime dataDiaSemana;
    private DateTime dataFimSemana;

    private VaiRex vaiRex;
    private MeuCaninoFeliz meuCanino;
    private ChowChawgas chowChawgas;
    
    [TestInitialize]
    public void InicializaVariaveisDosTestes()
    {
      dataDiaSemana = new DateTime(2019, 11, 7);
      dataFimSemana = new DateTime(2019, 11, 9);
    }
    #endregion Variáveis e Inicializadores

    #region Verificação de Valores
    [TestMethod]
    [TestCategory("Valores")]
    public void ValidaOrcamentoParaDiaDeSemanaTest()
    {
      DevolveInformacoesOrcamento(1, 1, dataDiaSemana);

      Assert.AreEqual(65.0, vaiRex.TotalizadorDosBanhos, 0.00001);
      Assert.AreEqual(60.0, meuCanino.TotalizadorDosBanhos, 0.00001);
      Assert.AreEqual(75.0, chowChawgas.TotalizadorDosBanhos, 0.00001);
    }

    [TestMethod]
    [TestCategory("Valores")]
    public void ValidaOrcamentoParaFinalDeSemanaTest()
    {
      DevolveInformacoesOrcamento(1, 1, dataFimSemana);

      Assert.AreEqual(75.0, vaiRex.TotalizadorDosBanhos, 0.00001);
      Assert.AreEqual(72.0, meuCanino.TotalizadorDosBanhos, 0.00001);
      Assert.AreEqual(75.0, chowChawgas.TotalizadorDosBanhos, 0.00001);
    }
    #endregion Verificação de Valores

    #region Comparação de Orçamentos
    [TestMethod]
    [TestCategory("Orçamentos")]
    public void ComparaOrcamentosPorMenorValor_PrimeiroPetShop_Test()
    {
      vaiRex = new VaiRex(2, 2, dataDiaSemana);
      meuCanino = new MeuCaninoFeliz(3, 5, dataDiaSemana);
      chowChawgas = new ChowChawgas(4, 4, dataDiaSemana);

      vaiRex.CalculaTotalDoBanho();
      meuCanino.CalculaTotalDoBanho();
      chowChawgas.CalculaTotalDoBanho();

      var orcamento = new ComparadorDeOrcamentos();
      orcamento.OrcamentoDosBanhosNosPets(vaiRex, meuCanino, chowChawgas);
    }

    [TestMethod]
    [TestCategory("Orçamentos")]
    public void ComparaOrcamentosPorMenorValor_TerceiroPetShop_Test()
    {
      vaiRex = new VaiRex(3, 5, dataDiaSemana);
      meuCanino = new MeuCaninoFeliz(4, 4, dataDiaSemana);
      chowChawgas = new ChowChawgas(2, 2, dataDiaSemana);

      vaiRex.CalculaTotalDoBanho();
      meuCanino.CalculaTotalDoBanho();
      chowChawgas.CalculaTotalDoBanho();

      var orcamento = new ComparadorDeOrcamentos();
      orcamento.OrcamentoDosBanhosNosPets(vaiRex, meuCanino, chowChawgas);
    }

    [TestMethod]
    [TestCategory("Orçamentos")]
    public void ComparaOrcamentosPorDistancia()
    {
      vaiRex = new VaiRex(4, 36, dataDiaSemana);
      meuCanino = new MeuCaninoFeliz(3, 45, dataDiaSemana);
      chowChawgas = new ChowChawgas(2, 40, dataDiaSemana);

      vaiRex.CalculaTotalDoBanho();
      meuCanino.CalculaTotalDoBanho();
      chowChawgas.CalculaTotalDoBanho();

      var orcamento = new ComparadorDeOrcamentos();
      orcamento.OrcamentoDosBanhosNosPets(vaiRex, meuCanino, chowChawgas);
    }

    #endregion Comparação de Orçamentos

    #region Métodos comuns aos Testes
    private void DevolveInformacoesOrcamento(int qtdeP, int qtdeG, DateTime data)
    {
      vaiRex = new VaiRex(qtdeP, qtdeG, data);
      meuCanino = new MeuCaninoFeliz(qtdeP, qtdeG, data);
      chowChawgas = new ChowChawgas(qtdeP, qtdeG, data);

      vaiRex.CalculaTotalDoBanho();
      meuCanino.CalculaTotalDoBanho();
      chowChawgas.CalculaTotalDoBanho();
    }
    #endregion Métodos comuns aos Testes

  }
}

