using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace YouGym
{
    public partial class FormularioDeRegistro : Form
    {
        int lx, ly;
        int sw, sh;
        int cantidadFormularios = 2;
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        public FormularioDeRegistro()
        {
            InitializeComponent();
        }
        //Funcion de botones
        private void btnAtras_Click(object sender, EventArgs e)
        {
            CerrarFormulariosCiclo();
            AbrirFormulario<Login>();
            labelCreaCuenta.Visible = false;
            labelCategoria.Visible = false;
            comboBoxCategoria.Visible = false;
            labelNombres.Visible = false;
            bunifuSeparatorNombres.Visible = false;
            textBoxNombres.Visible = false;
            labelApellidos.Visible = false;
            bunifuSeparatorApellidos.Visible = false;
            textBoxApellidos.Visible = false;
            labelNombreUsuario.Visible = false;
            bunifuSeparatorNombreUsuario.Visible = false;
            textBoxNombreUsuario.Visible = false;
            labelContraseña.Visible = false;
            bunifuSeparatorContraseña.Visible = false;
            textBoxContraseña.Visible = false;
            btnCrear.Visible = false;
            btnCancelar.Visible = false;
            btnAtras.Visible = false;
        }
        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            CerrarFormulariosCiclo();
            AbrirFormulario<Login>();
            labelCreaCuenta.Visible = false;
            labelCategoria.Visible = false;
            comboBoxCategoria.Visible = false;
            labelNombres.Visible = false;
            bunifuSeparatorNombres.Visible = false;
            textBoxNombres.Visible = false;
            labelApellidos.Visible = false;
            bunifuSeparatorApellidos.Visible = false;
            textBoxApellidos.Visible = false;
            labelNombreUsuario.Visible = false;
            bunifuSeparatorNombreUsuario.Visible = false;
            textBoxNombreUsuario.Visible = false;
            labelContraseña.Visible = false;
            bunifuSeparatorContraseña.Visible = false;
            textBoxContraseña.Visible = false;
            btnCrear.Visible = false;
            btnCancelar.Visible = false;
            btnAtras.Visible = false;
        }
        //Gstion de formularios
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelContenedorRegistro.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelContenedorRegistro.Controls.Add(formulario);
                panelContenedorRegistro.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }
        private void CerrarFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelContenedorRegistro.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario != null)
            {
                formulario.Close();
            }
        }
        private void CerrarFormularioSwicth(int FormularioCerrar)
        {
            switch (FormularioCerrar)
            {
                case 1:
                    CerrarFormulario<FormularioDeRegistro>();
                    break;
                case 2:
                    CerrarFormulario<YouGym>();
                    break;
            }
        }
        private void CerrarFormulariosCiclo()
        {
            for (int i = 1; i <= cantidadFormularios; i++)
            {
                CerrarFormularioSwicth(i);
            }
        }
    }
}
