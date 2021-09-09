using BilheteLoteriaPremiado;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BilhetePremiado
{
  public partial class Form_Principal : Form
  {
    public Form_Principal() => InitializeComponent();

    private void btn_jogar_Click(object sender, EventArgs e)
    {
      var qtdeDezenas = Convert.ToInt32(_quantidadeDezenas.Value);
      var qtdeSorteios = string.IsNullOrEmpty(_quantidadeSimulacoes.Text) ? 0 : int.Parse(_quantidadeSimulacoes.Text);

      if (qtdeSorteios < 1)
      {
        MessageBox.Show(BilheteLoteriaPremiado.Properties.Resources.AvisoQtdeSimulacoes, "AVISO !!",
          MessageBoxButtons.OK, MessageBoxIcon.Warning);
        _quantidadeDezenas.Focus();
      }
      else
      {
        var arquvioSorteios = new SalvaCartelasDeCadaSorteio();
        var resultados = new List<string>();
        var totalizadorResultados = new ContagemMaisSorteados();

        for (int x = 0; x < qtdeSorteios; x++)
        {
          var novoJogo = new EstruturaSorteios(qtdeDezenas, qtdeSorteios);
          novoJogo.RealizaSorteios();
          totalizadorResultados.SalvaTodosOsSorteios(novoJogo.SorteioDoDia);
          resultados = arquvioSorteios.CriaArquivoCanhotos(novoJogo.SorteioDoDia);
        }

        arquvioSorteios.SalvaSorteiosEmArquivo(resultados, qtdeDezenas, qtdeSorteios);
        var resultadoFinal = totalizadorResultados.RecuperaMaisSorteados(qtdeDezenas);

        MontaInterfaceResultado(resultadoFinal);
      }
    }

    private void MontaInterfaceResultado(List<int> lista)
    {
      var position_y = -30; //45;  // incremento de 75
      var contador = -3;
      int linhas = CalculaLinhasTabResult(lista.Count);

      for (int i = 0; i < linhas; i++)
      {
        position_y += 75;
        contador += 3;
        for (int j = contador; j < contador + 3; j++)
        {
          if (j == lista.Count)
            return;

          var position_x = 500;
          if (j % 3 == 0)
            position_x += 0;
          else if (j % 3 == 1)
            position_x += 100;
          else if (j % 3 == 2)
            position_x += 200;

          CriaBotaoResultadp(position_x, position_y, lista[j]);
        }
      }
    }

    private int CalculaLinhasTabResult(int count) => (count % 3 == 0) ? count / 3 : (count / 3) + 1;

    private void CriaBotaoResultadp(int position_x, int position_y, int numeroDaSorte)
    {
      Button button = new Button();

      button.Location = new System.Drawing.Point(position_x, position_y);
      button.Width = 60;
      button.Height = 60;
      button.BackColor = System.Drawing.Color.LimeGreen;
      button.ForeColor = System.Drawing.Color.LimeGreen;
      button.FlatStyle = FlatStyle.Flat;
      button.Font = new System.Drawing.Font("STENCIL", 20, System.Drawing.FontStyle.Bold);
      button.Text = numeroDaSorte.ToString().Length == 1 ? $"0{numeroDaSorte.ToString()}" : numeroDaSorte.ToString();
      button.Enabled = false;
      button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

      GraphicsPath forma = new GraphicsPath();
      forma.AddEllipse(0, 0, button.Width, button.Height);
      button.Region = new System.Drawing.Region(forma);

      Controls.Add(button);
    }
  }
}
