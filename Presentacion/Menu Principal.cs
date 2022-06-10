using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
//se importa la libreria para arrastrar ventana
using System.Runtime.InteropServices;

namespace YouGym
{
    public partial class YouGym : Form
    {
        int lx, ly;
        int sw, sh;
        int cantidadFormularios = 6;
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        public YouGym()
        {
            InitializeComponent();
            Inicializar();
            hideSubMenu();
            logoBackGround.Visible = true;
        }
        private void Inicializar()
        {
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }
        private void CerrarYAbrirImagen()
        {
            if(logoBackGround.Visible == false)
            {
                logo.Visible = true;
            }
            else
            {
                if (logoBackGround.Visible == true)
                {
                    logo.Visible = false;
                }
            }
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }

        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.PnlContenedor.Region = region;
            this.Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        private void PnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = PnlContenedorInterno.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                PnlContenedorInterno.Controls.Add(formulario);
                PnlContenedorInterno.Tag = formulario;
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
            formulario = PnlContenedorInterno.Controls.OfType<MiForm>().FirstOrDefault();
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
                    CerrarFormulario<RegistrarDatosUsuario>();
                    break;
                case 2:
                    CerrarFormulario<RegistrarDatosEntrenador>();
                    break;
                case 3:
                    CerrarFormulario<RegistrarAdminServicios>();
                    break;
                case 4:
                    CerrarFormulario<RegistrarPlanEjercicio>();
                    break;
                case 5:
                    CerrarFormulario<RegistrarServiciosGym>();
                    break;
                case 6:
                    CerrarFormulario<ConsultarDatosEntrenador>();
                    break;
                case 7:
                    CerrarFormulario<ConsultarDatosUsuario>();
                    break;
                case 8:
                    CerrarFormulario<ConsultarPlanEjercicio>();
                    break;
                case 9:
                    CerrarFormulario<ConsultarServicios>();
                    break;
                case 10:
                    CerrarFormulario<EliminarDatosDeServicio>();
                    break;
                case 11:
                    CerrarFormulario<EliminarUsuarioEntrenador>();
                    break;
            }
        }
        //Cerrar los formularios abiertos
        private void CerrarFormulariosCiclo()
        {
            for (int i = 1; i <= cantidadFormularios; i++)
            {
                CerrarFormularioSwicth(i);
            }
        }
        private void hideSubMenu()
        {
            subMenuUsuario.Visible = false;
            subMenuEntrenador.Visible = false;
            subMenuServicios.Visible = false;
            subMenuCaja.Visible = false;
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
        private void btnRegistrarDatosUsuario_Click(object sender, EventArgs e)
        {
            logoBackGround.Visible = false;
            CerrarYAbrirImagen();
            CerrarFormulariosCiclo();
            AbrirFormulario<RegistrarDatosUsuario>();
        }
        private void btnConsultarPlanDeEjercicios_Click(object sender, EventArgs e)
        {
            logoBackGround.Visible = false;
            CerrarYAbrirImagen();
            CerrarFormulariosCiclo();
            AbrirFormulario<ConsultarPlanEjercicio>();
        }
        private void btnConsultarDatosUsuario_Click(object sender, EventArgs e)
        {
            logoBackGround.Visible = false;
            CerrarFormulariosCiclo();
            AbrirFormulario<ConsultarDatosUsuario>();
        }
        //Gestionar Entrenador
        private void btnGestionarEntrenadores_Click(object sender, EventArgs e)
        {
            showSubMenu(subMenuEntrenador);
        }
        private void btnRegistrarDatosEntrenador_Click(object sender, EventArgs e)
        {
            logoBackGround.Visible = false;
            logoBackGround.Visible = false;
            CerrarFormulariosCiclo();
            AbrirFormulario<RegistrarDatosEntrenador>();
        }
        private void btnAsignarPlanDeEjercicios_Click_1(object sender, EventArgs e)
        {
            logoBackGround.Visible = false;
            CerrarFormulariosCiclo();
            AbrirFormulario<RegistrarPlanEjercicio>();
        }
        private void btConsultarDatosEntrenador_Click(object sender, EventArgs e)
        {
            logoBackGround.Visible = false;
            CerrarFormulariosCiclo();
            AbrirFormulario<ConsultarDatosEntrenador>();
        }
        //Gestionar Servicios
        private void btnGestionarServicios_Click_1(object sender, EventArgs e)
        {
            showSubMenu(subMenuServicios);
        }
        private void btnResgistrarAdminDeServicios_Click(object sender, EventArgs e)
        {
            logoBackGround.Visible = false;
            CerrarFormulariosCiclo();
            AbrirFormulario<RegistrarAdminServicios>();
        }
        private void btnAsignarServiciosGym_Click(object sender, EventArgs e)
        {
            logoBackGround.Visible = false;
            CerrarFormulariosCiclo();
            AbrirFormulario<RegistrarServiciosGym>();
        }
        private void btnConsultarServicios_Click_1(object sender, EventArgs e)
        {
            logoBackGround.Visible = false;
            CerrarFormulariosCiclo();
            AbrirFormulario<ConsultarServicios>();
        }
        private void btnEliminarDatosServicio_Click(object sender, EventArgs e)
        {
            logoBackGround.Visible = false;
            CerrarFormulariosCiclo();
            AbrirFormulario<EliminarDatosDeServicio>();
        }
        private void EliminarUsuarioEntrenador_Click(object sender, EventArgs e)
        {
            logoBackGround.Visible = false;
            CerrarFormulariosCiclo();
            AbrirFormulario<EliminarUsuarioEntrenador>();
        }
        //Gestionar caja
        private void btnGestionarCaja_Click(object sender, EventArgs e)
        {
            showSubMenu(subMenuCaja);
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
            Maximizar.Visible = true;
        }
        //Cerrar Sesion
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            logoBackGround.Visible = false;
            CerrarFormulariosCiclo();
            AbrirFormulario<PanelLogin>();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
    }
}