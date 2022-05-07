using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ToolBox
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            //Oculto el boton restaurar
            btnRestaurar.Visible = false;
            EventArgs e = null;
            //Llamo al evento click del logo
            logo_Click(null, e);
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            //Salgo de la aplicación
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            //Cuando maximizo, oculto el boton maximizar y muestro el boton restaurar
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            //Minimizo el programa
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            //Cuando restauro, oculto el boton restaurar y muestro el boton maximizar
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        //Para mover la ventana desde la barra de titulo
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Para abrir los formularios hijos
        private void AbrirForm(object formHijo)
        {
            //Si en el contenedor de formularios hijos, hay algun control...
            if (this.Contenedor.Controls.Count > 0)
            {
                //Lo borro
                this.Contenedor.Controls.RemoveAt(0);
            }
            //Creo un nuevo formulario con el objeto que recibo en la función
            Form fh = formHijo as Form;
            //No es un formulario principal, es un formulario secundario
            fh.TopLevel = false;
            //Ocupo todo el contenedor
            fh.Dock = DockStyle.Fill;
            //Lo agrego al contenedor
            this.Contenedor.Controls.Add(fh);
            this.Contenedor.Tag = fh;
            fh.Show();
            this.lblTitulo.Text = "ToolBox";
            this.lblTitulo.Text += $" - {fh.Text}";
        }

        private void btnSistemaFrances_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmPrestamoSistemaFrances());
        }

        private void logo_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmFechaHora());
        }
    }
}
