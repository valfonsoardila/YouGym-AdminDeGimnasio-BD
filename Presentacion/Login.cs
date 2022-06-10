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
    public partial class Login : Form
    {
        int lx, ly;
        int sw, sh;
        int cantidadFormularios = 2;
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        public Login()
        {
            InitializeComponent();
        }
        //Funciones de Botones
        private void btnVerPassword_Click(object sender, EventArgs e)
        {
            btnVerPassword.Visible = false;
            btnNoVerPassword.Visible = true;
            textContraseña.UseSystemPasswordChar = true;
        }
        private void btnNoVerPassword_Click(object sender, EventArgs e)
        {
            btnNoVerPassword.Visible = false;
            btnVerPassword.Visible = true;
            textContraseña.UseSystemPasswordChar = false;
        }
        private void btnOlvideContraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CerrarFormulariosCiclo();
            AbrirFormulario<RecuperarContraseña>();
            panel2.Visible = false;
            pictureBox1.Visible = false;
            label1.Visible = false;
            iconPictureBox1.Visible = false;
            iconPictureBox2.Visible = false;
            textUsuario.Visible = false;
            textContraseña.Visible = false;
            bunifuSeparator1.Visible = false;
            bunifuSeparator2.Visible = false;
            btnOlvideContraseña.Visible = false;
            btnAcceder.Visible = false;
        }
        private void btnNoTengoCuenta_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CerrarFormulariosCiclo();
            AbrirFormulario<FormularioDeRegistro>();
            panel2.Visible = false;
            pictureBox1.Visible = false;
            label1.Visible = false;
            iconPictureBox1.Visible = false;
            iconPictureBox2.Visible = false;
            textUsuario.Visible = false;
            textContraseña.Visible = false;
            bunifuSeparator1.Visible = false;
            bunifuSeparator2.Visible = false;
            btnOlvideContraseña.Visible = false;
            btnAcceder.Visible = false;
        }
        //Funciones cajas de texto
        private void textContraseña_Enter(object sender, EventArgs e)
        {
            if (textContraseña.Text == "Contraseña")
            {
                textContraseña.Text = "";
                textContraseña.ForeColor = Color.FromArgb(140, 3, 3);
                textContraseña.UseSystemPasswordChar = true;
            }
        }
        private void textContraseña_Leave(object sender, EventArgs e)
        {
            if (textContraseña.Text == "")
            {
                textContraseña.Text = "Contraseña";
                textContraseña.ForeColor = Color.Black;
                textContraseña.UseSystemPasswordChar = false;
            }
        }
        private void textUsuario_Enter_1(object sender, EventArgs e)
        {
            if (textUsuario.Text == "Usuario")
            {
                textUsuario.Text = "";
                textUsuario.ForeColor = Color.FromArgb(140, 3, 3);
            }
        }
        private void textUsuario_Leave_1(object sender, EventArgs e)
        {
            if (textUsuario.Text == "")
            {
                textUsuario.Text = "Usuario";
                textUsuario.ForeColor = Color.Black;
            }
        }
        //Gstion de formularios
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelContenedorLogin.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelContenedorLogin.Controls.Add(formulario);
                panelContenedorLogin.Tag = formulario;
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
            formulario = panelContenedorLogin.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario != null)
            {
                formulario.Close();
            }
        }

        private void panelContenedorLogin_Paint(object sender, PaintEventArgs e)
        {

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
