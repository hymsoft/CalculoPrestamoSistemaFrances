using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ToolBox
{
    public partial class PruebaControlesPersonalizados : Form
    {
        
        private static float minTNA = 0.01f;
        private static int minCapital = 1000;
        private static int maxCapital = 1000000;
        private static int minAnios = 1;
        private static int maxAnios = 10;
        private string msgVacio = "Este campo es obligatorio";
        private string msgMontoCapital = $"El capital solicitado tiene que ser\nmayor que {minCapital} y\nmenor que {maxCapital}";
        private string msgMontoTNA = $"La TNA tiene que ser\nmayor que {minTNA}%";
        private string msgAnios = $"Los años tienen que ser\nmayor o igual a {minAnios} y\nmenor o igual a {maxAnios}";

        public PruebaControlesPersonalizados()
        {
            InitializeComponent();
        }

        private void txtCapital_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Permito solo numeros positivos 
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTNA_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Permito 
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Solo un punto decimal
            if ((e.KeyChar == '.') && (txtTNA.Texts.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void txtPeriodoEnAnios_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ValidarCampos()
        {
            //Borro los errores
            errorProvider1.SetError(txtCapital, "");
            errorProvider1.SetError(txtTNA, "");
            errorProvider1.SetError(txtPeriodoEnAnios, "");
            //Capital | NoVacio | > minCapital && < maxCapital
            if (txtCapital.Texts == "") errorProvider1.SetError(txtCapital, msgVacio);
            else if (int.Parse(txtCapital.Texts) < minCapital | int.Parse(txtCapital.Texts) > maxCapital) errorProvider1.SetError(txtCapital, msgMontoCapital);
            //TNA | NoVacio | > minTNA
            if (txtTNA.Texts == "") errorProvider1.SetError(txtTNA, msgVacio);
            else if (double.Parse(txtTNA.Texts) < minTNA ) errorProvider1.SetError(txtTNA, msgMontoTNA);
            //Anios | NoVacio | > minAnios && < maxAnios
            if (txtPeriodoEnAnios.Texts == "") errorProvider1.SetError(txtPeriodoEnAnios, msgVacio);
            else if (int.Parse(txtPeriodoEnAnios.Texts) < minAnios | int.Parse(txtPeriodoEnAnios.Texts) > minAnios) errorProvider1.SetError(txtPeriodoEnAnios, msgAnios);
        }

        private void btnCalcularImporteCuotas_Click(object sender, System.EventArgs e)
        {
            ValidarCampos();
        }

      
    }
}
