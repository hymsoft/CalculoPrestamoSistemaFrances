using Negocio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace ToolBox
{
    public partial class FrmPrestamoSistemaFrances : Form
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
        private string msgOverFlow = "Número demasiado grande...";
        private string msgJokerOverFlow = "No se hagan los vivos y pongan un monto serio, caramba, somos grandes ya...";

        public FrmPrestamoSistemaFrances()
        {
            InitializeComponent();
        }

        private void ImporteCuotas()
        {
            //Vacio el grid, por si tiene datos
            gridDesglose.Rows.Clear();
            //creo el objeto
            SistemaFrances prestamo = new SistemaFrances();
            //Cargo las variables con los datos ingresados
            double capital = double.Parse(txtCapital.Texts);
            double tasa = double.Parse(txtTNA.Texts);
            int periodoEnAnios = int.Parse(txtPeriodoEnAnios.Texts);
            string frecuenciaDePagos = cmbFrecuenciaDePagos.Text;
            //Algunos calculos elementales, obtenidos de la clase para poder averiguar la cuota a pagar
            //realmente no es necesario, pero muestro estos datos en el formulario
            int pagosPorAnio = prestamo.PagosPorAnio(frecuenciaDePagos);
            int totalDeCuotas = prestamo.TotalDeCuotas(periodoEnAnios, frecuenciaDePagos);
            double interesEquivalente = prestamo.TasaEquivalente(tasa, pagosPorAnio);
            //Obtengo la cuota a pagar
            double cuotaAPagar = prestamo.CuotaAPagar(capital, tasa, periodoEnAnios, frecuenciaDePagos);
            //Cargo en el formulario los datos recibidos de la clase
            txtPagosPorAnio.Texts = pagosPorAnio.ToString();
            txtTotalDeCuotas.Texts = totalDeCuotas.ToString();
            txtInteresEquivalente.Texts = interesEquivalente.ToString("0.#####");
            //Primer item del grid o item 0
            gridDesglose.Rows.Add("0", "", "", "", capital.ToString("C", CultureInfo.CurrentCulture));
            //Obtengo el listado de las cuotas
            double[,] listadoDeCuotas = prestamo.ListadoDeCuotas(capital, interesEquivalente, totalDeCuotas, cuotaAPagar);
            //Lleno el grid con los datos recibidos
            for (int i = 0; i < totalDeCuotas; i++)
            {
                gridDesglose.Rows.Add(
                    i + 1,
                    cuotaAPagar.ToString("C", CultureInfo.CurrentCulture),
                    listadoDeCuotas[i, 0].ToString("C", CultureInfo.CurrentCulture),
                    listadoDeCuotas[i, 1].ToString("C", CultureInfo.CurrentCulture),
                    listadoDeCuotas[i, 2].ToString("C", CultureInfo.CurrentCulture)
                    );
            }
            //Actualizo las sumas de las cuotas y los intereses, tambien obtenidos por metodos de la clase
            txtSumaDeCuotas.Texts = prestamo.getSumaDeCuotas().ToString("C", CultureInfo.CurrentCulture);
            txtSumaDeIntereses.Texts = prestamo.getSumaDeIntereses().ToString("C", CultureInfo.CurrentCulture);
        }

        private bool ValidarCampos()
        {
            //Borro los datos por si habia un calculo anterior
            BorrarDatos();
            //Borro los errores
            errorProvider1.SetError(txtCapital, "");
            errorProvider1.SetError(txtTNA, "");
            errorProvider1.SetError(txtPeriodoEnAnios, "");
            //Capital | NoVacio | > minCapital && < maxCapital
            if (txtCapital.Texts == "")
            {
                errorProvider1.SetError(txtCapital, msgVacio);
                return false;
            }
            else
            {
                try
                {
                    if (int.Parse(txtCapital.Texts) < minCapital | int.Parse(txtCapital.Texts) > maxCapital)
                    {
                        errorProvider1.SetError(txtCapital, msgMontoCapital);
                        return false;
                    }
                }
                catch (OverflowException)
                {
                    errorProvider1.SetError(txtCapital, msgJokerOverFlow);
                    return false;
                }
            }
            //TNA | NoVacio | > minTNA
            if (txtTNA.Texts == "")
            {
                errorProvider1.SetError(txtTNA, msgVacio);
                return false;
            }
            else if (double.Parse(txtTNA.Texts) < minTNA)
            {
                errorProvider1.SetError(txtTNA, msgMontoTNA);
                return false;
            }
            //Anios | NoVacio | > minAnios && < maxAnios
            if (txtPeriodoEnAnios.Texts == "")
            {
                errorProvider1.SetError(txtPeriodoEnAnios, msgVacio);
                return false;
            }
            else try
                {
                    if (int.Parse(txtPeriodoEnAnios.Texts) < minAnios | int.Parse(txtPeriodoEnAnios.Texts) > maxAnios)
                    {
                        errorProvider1.SetError(txtPeriodoEnAnios, msgAnios);
                        return false;
                    }
                }
                catch (OverflowException)
                {
                    errorProvider1.SetError(txtPeriodoEnAnios, msgOverFlow);
                    return false;
                }
            return true;
        }

        private void BorrarDatos()
        {
            gridDesglose.Rows.Clear();
            txtInteresEquivalente.Texts = "";
            txtPagosPorAnio.Texts = "";
            txtTotalDeCuotas.Texts = "";
            txtSumaDeCuotas.Texts = "";
            txtSumaDeIntereses.Texts = "";
        }

        private void frmPrestamoSistemaFrances_Load(object sender, EventArgs e)
        {
            //Lleno el combo con los datos de periodicidad
            //var periodicidad = new[] { "Mensual", "Bimestral", "Trimestral", "Cuatrimestral", "Semestral", "Anual" };
            List<string> periodicidad = new List<string>();
            periodicidad.Add("Mensual");
            periodicidad.Add("Bimestral");
            periodicidad.Add("Trimestral");
            periodicidad.Add("Cuatrimestral");
            periodicidad.Add("Semestral");
            periodicidad.Add("Anual");

            foreach (string dato in periodicidad)
            {
                cmbFrecuenciaDePagos.Items.Add(dato);
            }
            //Doy Formato a los encabezados del grid
            foreach (DataGridViewColumn col in gridDesglose.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }

            //Algunos datos por defecto
            txtCapital.Texts = "15000";
            txtTNA.Texts = "8";
            txtPeriodoEnAnios.Texts = "2";
            int index = cmbFrecuenciaDePagos.FindString("Mensual");
            cmbFrecuenciaDePagos.SelectedIndex = index;
        }

        private void btnCalcularImporteCuotas_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                ImporteCuotas();
            }
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

    }
}
