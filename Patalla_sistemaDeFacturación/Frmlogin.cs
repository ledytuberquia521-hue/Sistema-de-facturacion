using System;
using System.Data;
using System.Windows.Forms;
using Capa_LogicaDeNegocios;

namespace Patalla_sistemaDeFacturación
{
    public partial class Frmlogin : Form
    {
        public Frmlogin()
        {
            InitializeComponent();
        }

        // Evento: carga del formulario
        private void Frmlogin_Load(object sender, EventArgs e)
        {
            // Puedes inicializar aquí cualquier cosa al cargar el formulario
        }

        // Evento: botón cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Evento: botón validar
        private void btnValidar_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (!string.IsNullOrWhiteSpace(TxtUsuario.Text) && !string.IsNullOrWhiteSpace(TxtPassword.Text))
            {
                try
                {
                    // Crear el objeto de la clase Validar_Usuario
                    Validar_Usuario Obj_validar = new Validar_Usuario
                    {
                        C_StrUsuario = TxtUsuario.Text.Trim(),
                        C_StrClave = TxtPassword.Text.Trim()
                    };

                    // Llamar el método que valida el usuario
                    Obj_validar.ValidarUsuario();

                    // Si encuentra el usuario
                    if (Obj_validar.C_IdEmpleado != 0)
                    {
                        MessageBox.Show($"✅ Bienvenido {TxtUsuario.Text}",
                            "Acceso permitido",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        // Abrir el formulario principal
                        FrmPrincipal frmPrincipal = new FrmPrincipal();
                        this.Hide();
                        frmPrincipal.Show();
                    }
                    else
                    {
                        MessageBox.Show("❌ Usuario o clave incorrectos.",
                            "Error de autenticación",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        TxtUsuario.Clear();
                        TxtPassword.Clear();
                        TxtUsuario.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("⚠️ Error al validar el usuario: " + ex.Message,
                        "Error del sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese su usuario y contraseña.",
                    "Campos vacíos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        // (Opcional) Eventos del formulario o etiquetas — los puedes eliminar si no se usan
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {
        }
    }
}
