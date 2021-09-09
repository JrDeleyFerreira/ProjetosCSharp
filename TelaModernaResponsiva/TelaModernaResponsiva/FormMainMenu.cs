using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TelaModernaResponsiva
{
  public partial class FormMainMenu : Form
  {
    //Fields
    private Button currentButton;
    private Random random;
    private int tempIndex;
    private Form activeForm;

    public FormMainMenu()
    {
      InitializeComponent();
      random = new Random();
      //btnCloseChildForm.Visible = false;
      this.Text = string.Empty;
      this.ControlBox = false;
      this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
    }

    [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
    private extern static void ReleaseCapture();
    [DllImport("user32.DLL", EntryPoint = "SendMessage")]
    private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

    //Methods
    private Color SelectThemeColor()
    {
      int index = random.Next(ThemeColor.ColorList.Count);
      while (tempIndex == index)
      {
        index = random.Next(ThemeColor.ColorList.Count);
      }
      tempIndex = index;
      string color = ThemeColor.ColorList[index];
      return ColorTranslator.FromHtml(color);
    }

    private void ActivateButton(object btnSender)
    {
      if (btnSender != null)
      {
        if (currentButton != (Button)btnSender)
        {
          DisableButton();
          Color color = SelectThemeColor();
          currentButton = (Button)btnSender;
          currentButton.BackColor = color;
          currentButton.ForeColor = Color.White;
          currentButton.Font = new Font("Microsoft Sans Serif", 12.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
          panelTitleBar.BackColor = color;
          panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
          ThemeColor.PrimaryColor = color;
          ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
          //btnCloseChildForm.Visible = true;
        }
      }
    }

    private void DisableButton()
    {
      foreach (Control previousBtn in panelMenu.Controls)
      {
        if (previousBtn.GetType() == typeof(Button))
        {
          previousBtn.BackColor = Color.FromArgb(51, 51, 76);
          previousBtn.ForeColor = Color.Gainsboro;
          previousBtn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
        }
      }
    }

    private void OpenChildForm(Form childForm, object btnSender)
    {
      if (activeForm != null)
        activeForm.Close();
      ActivateButton(btnSender);
      activeForm = childForm;
      childForm.TopLevel = false;
      childForm.FormBorderStyle = FormBorderStyle.None;
      childForm.Dock = DockStyle.Fill;
      this.panelDesktopPanel.Controls.Add(childForm);
      this.panelDesktopPanel.Tag = childForm;
      childForm.BringToFront();
      childForm.Show();
      lblTitle.Text = childForm.Text;
    }

    private void btnProdutos_Click(object sender, EventArgs e)
    {
      ActivateButton(sender);
      // OpenChildForm(new Forms.FormReporting(), sender);
    }

    private void button1_Click(object sender, EventArgs e)
    {
      ActivateButton(sender);
    }

    private void button2_Click(object sender, EventArgs e)
    {
      ActivateButton(sender);
    }

    private void button3_Click(object sender, EventArgs e)
    {
      ActivateButton(sender);
    }

    private void button4_Click(object sender, EventArgs e)
    {
      ActivateButton(sender);
    }

    private void button5_Click(object sender, EventArgs e)
    {
      ActivateButton(sender);
    }

    private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
    {
      ReleaseCapture();
      SendMessage(this.Handle, 0x112, 0xf012, 0);
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void btnMaximize_Click(object sender, EventArgs e)
    {
      if (WindowState == FormWindowState.Normal)
        this.WindowState = FormWindowState.Maximized;
      else
        this.WindowState = FormWindowState.Normal;
    }

    private void btnMinimize_Click(object sender, EventArgs e)
    {
      this.WindowState = FormWindowState.Minimized;
    }
  }
}
