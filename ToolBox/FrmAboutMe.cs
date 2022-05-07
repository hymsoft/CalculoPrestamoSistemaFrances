using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolBox
{
    public partial class FrmAboutMe : Form
    {
        public FrmAboutMe()
        {
            InitializeComponent();
            this.lblAboutMe.Text = "\tSoy un antiguo programador, empecé con dbase, Clipper, FoxPro for D.O.S., Visual FoxPro, basic, visual basic...\n" +
                "\tApasionado por la tecnología, siempre estudiando y aprendiendo\n" +
                "\tUsuario avanzado en Excel\n" +
                "\tFerviente eliminador de virus informáticos sin pérdida de datos";
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private const int CS_DropShadow = 0x00020000;
        //Sombra
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DropShadow;
                return cp;
            }
        }


        private void linkEdin_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/hugo-antonio-segura-22099696/");
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/hymsoft");
            this.Dispose();

        }
    }
}
