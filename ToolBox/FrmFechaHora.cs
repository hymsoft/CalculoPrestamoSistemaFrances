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
    public partial class FrmFechaHora : Form
    {
        public FrmFechaHora()
        {
            InitializeComponent();
        }

        private void FechaHora_Tick(object sender, EventArgs e)
        {
            //Formato de hora larga
            LblHora.Text = DateTime.Now.ToLongTimeString();
            //Formato de Fecha Larga
            LblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void FrmFechaHora_Load(object sender, EventArgs e)
        {

        }

        private void LblHora_Click(object sender, EventArgs e)
        {

        }

        private void LblFecha_Click(object sender, EventArgs e)
        {

        }
    }
}
