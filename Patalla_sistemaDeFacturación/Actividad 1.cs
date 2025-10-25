using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;


namespace Patalla_sistemaDeFacturación
{
    public partial class FrmPrincipal : MaterialForm
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pnlPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }
        public void AbrirForm(Form formHijo)
        {
            if (this.pnlcontenedor.Controls.Count > 0)
                this.pnlcontenedor.Controls.RemoveAt(0);

            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

            this.pnlcontenedor.Controls.Add(formHijo);
           // pnlcontenedor.Tag = formHijo;

            formHijo.Show();
        }


               private void btnClientes_Click(object sender, EventArgs e)
        {
            
                frmListaClientes listaClientes = new frmListaClientes();
                AbrirForm(listaClientes);
            
        }


        private void BtnFacturas_Click(object sender, EventArgs e)
        {
           
        }

        private void tabOpcionesMenu_Click(object sender, EventArgs e)
        {

        }

        private void pnlcontenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
