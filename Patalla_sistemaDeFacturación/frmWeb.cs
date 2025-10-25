using System;
using System.Windows.Forms;

namespace Pantalla_sistemaDeFacturacion
{
    public class frmWeb : Form
    {
        private WebBrowser webBrowser;

        public frmWeb()
        {
            this.Text = "Visor Web";
            this.Width = 800;
            this.Height = 600;

            webBrowser = new WebBrowser();
            webBrowser.Dock = DockStyle.Fill;
            this.Controls.Add(webBrowser);

            this.Load += FrmWebView_Load;
        }

        private void FrmWebView_Load(object sender, EventArgs e)
        {
            webBrowser.Navigate("https://learn.microsoft.com/es-es/");
        }
    }
}
