using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Windows.Forms;
//se importa la libreria para arrastrar ventana
using System.Runtime.InteropServices;

namespace YouGym
{
    public partial class YouGym : Form
    {
        public YouGym()
        {
            InitializeComponent();
            hideSubMenu();
        }
        private void hideSubMenu()
        {
            subMenuUsuario.Visible = false;
            subMenuEntrenador.Visible = false;
            subMenuServicios.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        //Gestionar Usuario
        private void btnGestionarUsuario_Click_1(object sender, EventArgs e)
        {
            showSubMenu(subMenuUsuario);
        }
        //Gestionar Entrenador
        private void btnGestionarEntrenadores_Click(object sender, EventArgs e)
        {
            showSubMenu(subMenuEntrenador);
        }
        //Gestionar Servicios
        private void btnGestionarServicios_Click_1(object sender, EventArgs e)
        {
            showSubMenu(subMenuServicios);
        }
        //Botones de control
        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Maximizar.Visible = false;
            Restaurar.Visible = true;
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Restaurar.Visible = false;
        }
    }
}
