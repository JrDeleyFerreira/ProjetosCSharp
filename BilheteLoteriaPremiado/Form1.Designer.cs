
namespace BilhetePremiado
{
  partial class Form_Principal
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Principal));
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.lbl_qtde_Dezenas = new System.Windows.Forms.Label();
      this._quantidadeDezenas = new System.Windows.Forms.NumericUpDown();
      this.lbl_qtde_Simulacoes = new System.Windows.Forms.Label();
      this.btn_jogar = new System.Windows.Forms.Button();
      this._quantidadeSimulacoes = new System.Windows.Forms.MaskedTextBox();
      this.lbl_maisSorteados = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this._quantidadeDezenas)).BeginInit();
      this.SuspendLayout();
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = global::BilheteLoteriaPremiado.Properties.Resources.items;
      resources.ApplyResources(this.pictureBox1, "pictureBox1");
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.TabStop = false;
      // 
      // lbl_qtde_Dezenas
      // 
      resources.ApplyResources(this.lbl_qtde_Dezenas, "lbl_qtde_Dezenas");
      this.lbl_qtde_Dezenas.Name = "lbl_qtde_Dezenas";
      // 
      // _quantidadeDezenas
      // 
      this._quantidadeDezenas.BackColor = System.Drawing.SystemColors.HighlightText;
      resources.ApplyResources(this._quantidadeDezenas, "_quantidadeDezenas");
      this._quantidadeDezenas.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
      this._quantidadeDezenas.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
      this._quantidadeDezenas.Name = "_quantidadeDezenas";
      this._quantidadeDezenas.ReadOnly = true;
      this._quantidadeDezenas.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
      // 
      // lbl_qtde_Simulacoes
      // 
      resources.ApplyResources(this.lbl_qtde_Simulacoes, "lbl_qtde_Simulacoes");
      this.lbl_qtde_Simulacoes.Name = "lbl_qtde_Simulacoes";
      // 
      // btn_jogar
      // 
      resources.ApplyResources(this.btn_jogar, "btn_jogar");
      this.btn_jogar.Name = "btn_jogar";
      this.btn_jogar.UseVisualStyleBackColor = true;
      this.btn_jogar.Click += new System.EventHandler(this.btn_jogar_Click);
      // 
      // _quantidadeSimulacoes
      // 
      resources.ApplyResources(this._quantidadeSimulacoes, "_quantidadeSimulacoes");
      this._quantidadeSimulacoes.Name = "_quantidadeSimulacoes";
      this._quantidadeSimulacoes.ValidatingType = typeof(int);
      // 
      // lbl_maisSorteados
      // 
      resources.ApplyResources(this.lbl_maisSorteados, "lbl_maisSorteados");
      this.lbl_maisSorteados.ForeColor = System.Drawing.Color.Gold;
      this.lbl_maisSorteados.Name = "lbl_maisSorteados";
      // 
      // Form_Principal
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.lbl_maisSorteados);
      this.Controls.Add(this._quantidadeSimulacoes);
      this.Controls.Add(this.btn_jogar);
      this.Controls.Add(this.lbl_qtde_Simulacoes);
      this.Controls.Add(this._quantidadeDezenas);
      this.Controls.Add(this.lbl_qtde_Dezenas);
      this.Controls.Add(this.pictureBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "Form_Principal";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this._quantidadeDezenas)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label lbl_qtde_Dezenas;
    private System.Windows.Forms.NumericUpDown _quantidadeDezenas;
    private System.Windows.Forms.Label lbl_qtde_Simulacoes;
    private System.Windows.Forms.Button btn_jogar;
    private System.Windows.Forms.MaskedTextBox _quantidadeSimulacoes;
    private System.Windows.Forms.Label lbl_maisSorteados;
  }
}

