using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Patalla_sistemaDeFacturación
{
    public partial class fmrAcerda : Form
    {
        public fmrAcerda()
        {
            InitializeComponent();
            this.Text = $"Acerca del sistema de facturación";

            // Cargar datos del ensamblado
            labelProductName.Text = AssemblyProduct;
            labelVersion.Text = $"Versión {AssemblyVersion}";
            labelCopyright.Text = AssemblyCopyright;
            labelCompanyName.Text = AssemblyCompany;
            textBoxLegal.Text =
    "Advertencia: este programa está protegido por las leyes de derechos de autor y otros tratados internacionales. " +
    "La reproducción o distribución ilícita de este programa o de cualquier parte del mismo está penada por la ley " +
    "con severas sanciones civiles y penales y será objeto de todas las acciones judiciales que correspondan.";

            // Cargar lista de productos simulados
            listBoxProductos.Items.Add("Visual C++ 2017 – 00369-60000-00001-AA061");
            listBoxProductos.Items.Add("Administrador de paquetes NuGet – 4.6.0");
            listBoxProductos.Items.Add("Asistentes de Microsoft Visual C++ – 1.0");
            listBoxProductos.Items.Add("ASP.NET and Web Tools 2017 – 15.8.05085.0");
            listBoxProductos.Items.Add("ASP.NET Core Razor Language Services – 15.6.3.150");
            listBoxProductos.Items.Add("ASP.NET Web Frameworks and Tools 2017 – 5.2.60318.0");
            listBoxProductos.Items.Add("Azure App Service Tools v3.0.0 – 15.0.50302.0");
            listBoxProductos.Items.Add("Azure Functions and Web Jobs Tools – 15.9.02046.0");

            textBoxDescription.Text = AssemblyDescription;
            textBoxLegal.Text = "Advertencia: este programa está protegido por las leyes de derechos de autor ...";
            
        }

        #region Descriptores de acceso de atributos de ensamblado

        public string AssemblyTitle =>
            Assembly.GetExecutingAssembly()
                    .GetCustomAttribute<AssemblyTitleAttribute>()?.Title
            ?? System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);

        public string AssemblyVersion =>
            Assembly.GetExecutingAssembly().GetName().Version.ToString();

        public string AssemblyDescription =>
            Assembly.GetExecutingAssembly()
                    .GetCustomAttribute<AssemblyDescriptionAttribute>()?.Description ?? "";

        public string AssemblyProduct =>
            Assembly.GetExecutingAssembly()
                    .GetCustomAttribute<AssemblyProductAttribute>()?.Product ?? "";

        public string AssemblyCopyright =>
            Assembly.GetExecutingAssembly()
                    .GetCustomAttribute<AssemblyCopyrightAttribute>()?.Copyright ?? "";

        public string AssemblyCompany =>
            Assembly.GetExecutingAssembly()
                    .GetCustomAttribute<AssemblyCompanyAttribute>()?.Company ?? "";

        #endregion

        #region Eventos

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCopiarInfo_Click(object sender, EventArgs e)
        {
            string info =
                $"Producto: {AssemblyProduct}\n" +
                $"Versión: {AssemblyVersion}\n" +
                $"Empresa: {AssemblyCompany}\n" +
                $"Copyright: {AssemblyCopyright}\n\n" +
                "Productos instalados:\n" +
                string.Join("\n", listBoxProductos.Items.Cast<string>());

            Clipboard.SetText(info);
            MessageBox.Show("Información copiada al portapapeles.", "Copiado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonInfoSistema_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                $"Producto: {AssemblyProduct}\nVersión: {AssemblyVersion}\nEmpresa: {AssemblyCompany}",
                "Información del sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void buttonDxDiag_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("dxdiag");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo ejecutar DxDiag.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}
