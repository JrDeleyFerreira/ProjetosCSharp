using BanhoEmPet.PetShops;
using System;
using System.Windows.Forms;

namespace BanhoEmPet
{
  public partial class FormPrincipalBanhoEmCaes : Form
  {
    public FormPrincipalBanhoEmCaes()
    {
      InitializeComponent();
      dateTimeBanho.Format = DateTimePickerFormat.Custom;
      dateTimeBanho.CustomFormat = "dd/MM/yyyy";
    }

    private void btnCalcular_Click(object sender, EventArgs e)
    {
      if (tbxCaesGrandes.Text == tbxCaesPequenos.Text && tbxCaesGrandes.Text == "0")
      {
        MessageBox.Show(Properties.Resources.CamposQuantidadeIguaisAZero, "AVISO", 
          MessageBoxButtons.OK, MessageBoxIcon.Warning);
        tbxCaesGrandes.Focus();
      }
      else if (tbxCaesGrandes.Text == String.Empty || tbxCaesPequenos.Text == String.Empty)
      {
        MessageBox.Show(Properties.Resources.CamposQuantidadeVazios, "ATENÇÃO", 
          MessageBoxButtons.OK, MessageBoxIcon.Warning);
        tbxCaesGrandes.Focus();
      }
      else
      {
        int qtddPequenos = Convert.ToInt32(tbxCaesGrandes.Text);
        int qtddGrandes = Convert.ToInt32(tbxCaesPequenos.Text);
      
        var vaiRex = new VaiRex(qtddPequenos, qtddGrandes, dateTimeBanho.Value);
        var meuCanino = new MeuCaninoFeliz(qtddPequenos, qtddGrandes, dateTimeBanho.Value);
        var chowChaw = new ChowChawgas(qtddPequenos, qtddGrandes, dateTimeBanho.Value);

        vaiRex.CalculaTotalDoBanho();
        meuCanino.CalculaTotalDoBanho();
        chowChaw.CalculaTotalDoBanho();

        var comparadorDeOrcamentos = new ComparadorDeOrcamentos();
        comparadorDeOrcamentos.OrcamentoDosBanhosNosPets(vaiRex, meuCanino, chowChaw);
      }
    }

    private void tbxCaesGrandes_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)8)
        e.Handled = true;
    }

    private void tbxCaesPequenos_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)8)
        e.Handled = true;
    }
  }
}
