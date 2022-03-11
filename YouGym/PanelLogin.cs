using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//se importa la libreria para arrastrar ventana
using System.Runtime.InteropServices;

namespace YouGym
{
    public partial class PanelLogin : Form
    {
        int cantidadFormularios = 2;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        public PanelLogin()
        {
            InitializeComponent();
            CerrarFormulariosCiclo();
            AbrirFormulario<Login>();
        }
        private void panelBarraDeOpciones_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //Gestion de Formularios
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelContenedor.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelContenedor.Controls.Add(formulario);
                panelContenedor.Tag = formulario;
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
            formulario = panelContenedor.Controls.OfType<MiForm>().FirstOrDefault();
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
        //Botones de la barra de opciones
        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //Fragmento de codigo 1 para arrastrar ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
    }
}
