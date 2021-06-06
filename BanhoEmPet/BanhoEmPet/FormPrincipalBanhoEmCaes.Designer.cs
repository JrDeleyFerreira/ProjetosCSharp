namespace BanhoEmPet
{
  partial class FormPrincipalBanhoEmCaes
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipalBanhoEmCaes));
      this.btnCalcular = new System.Windows.Forms.Button();
      this.label_QtddCaesGrandes = new System.Windows.Forms.Label();
      this.label_QtddCaesPequenos = new System.Windows.Forms.Label();
      this.label_DataBanho = new System.Windows.Forms.Label();
      this.tbxCaesGrandes = new System.Windows.Forms.TextBox();
      this.tbxCaesPequenos = new System.Windows.Forms.TextBox();
      this.dateTimeBanho = new System.Windows.Forms.DateTimePicker();
      this.groupBox = new System.Windows.Forms.GroupBox();
      this.groupBox.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnCalcular
      // 
      resources.ApplyResources(this.btnCalcular, "btnCalcular");
      this.btnCalcular.Name = "btnCalcular";
      this.btnCalcular.UseVisualStyleBackColor = true;
      this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
      // 
      // label_QtddCaesGrandes
      // 
      resources.ApplyResources(this.label_QtddCaesGrandes, "label_QtddCaesGrandes");
      this.label_QtddCaesGrandes.Name = "label_QtddCaesGrandes";
      // 
      // label_QtddCaesPequenos
      // 
      resources.ApplyResources(this.label_QtddCaesPequenos, "label_QtddCaesPequenos");
      this.label_QtddCaesPequenos.Name = "label_QtddCaesPequenos";
      // 
      // label_DataBanho
      // 
      resources.ApplyResources(this.label_DataBanho, "label_DataBanho");
      this.label_DataBanho.Name = "label_DataBanho";
      // 
      // tbxCaesGrandes
      // 
      resources.ApplyResources(this.tbxCaesGrandes, "tbxCaesGrandes");
      this.tbxCaesGrandes.Name = "tbxCaesGrandes";
      this.tbxCaesGrandes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCaesGrandes_KeyPress);
      // 
      // tbxCaesPequenos
      // 
      resources.ApplyResources(this.tbxCaesPequenos, "tbxCaesPequenos");
      this.tbxCaesPequenos.Name = "tbxCaesPequenos";
      this.tbxCaesPequenos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCaesPequenos_KeyPress);
      // 
      // dateTimeBanho
      // 
      resources.ApplyResources(this.dateTimeBanho, "dateTimeBanho");
      this.dateTimeBanho.Name = "dateTimeBanho";
      // 
      // groupBox
      // 
      this.groupBox.Controls.Add(this.dateTimeBanho);
      this.groupBox.Controls.Add(this.tbxCaesPequenos);
      this.groupBox.Controls.Add(this.tbxCaesGrandes);
      this.groupBox.Controls.Add(this.label_DataBanho);
      this.groupBox.Controls.Add(this.label_QtddCaesPequenos);
      this.groupBox.Controls.Add(this.label_QtddCaesGrandes);
      this.groupBox.Controls.Add(this.btnCalcular);
      resources.ApplyResources(this.groupBox, "groupBox");
      this.groupBox.Name = "groupBox";
      this.groupBox.TabStop = false;
      // 
      // FormPrincipalBanhoEmCaes
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.groupBox);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.MaximizeBox = false;
      this.Name = "FormPrincipalBanhoEmCaes";
      this.groupBox.ResumeLayout(false);
      this.groupBox.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnCalcular;
    private System.Windows.Forms.Label label_QtddCaesGrandes;
    private System.Windows.Forms.Label label_QtddCaesPequenos;
    private System.Windows.Forms.Label label_DataBanho;
    private System.Windows.Forms.TextBox tbxCaesGrandes;
    private System.Windows.Forms.TextBox tbxCaesPequenos;
    private System.Windows.Forms.DateTimePicker dateTimeBanho;
    private System.Windows.Forms.GroupBox groupBox;
  }
}

