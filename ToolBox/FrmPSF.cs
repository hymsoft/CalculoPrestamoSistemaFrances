using Negocio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace ToolBox
{
    public partial class FrmPrestamoSistemaFrances : Form
    {
        public FrmPrestamoSistemaFrances()
        {
            InitializeComponent();
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

            foreach (string dato in periodicidad) { 
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
                for (int i = 0;i < totalDeCuotas; i++)
                {
                    gridDesglose.Rows.Add(
                        i+1,
                        cuotaAPagar.ToString("C", CultureInfo.CurrentCulture),
                        listadoDeCuotas[i,0].ToString("C", CultureInfo.CurrentCulture),
                        listadoDeCuotas[i,1].ToString("C", CultureInfo.CurrentCulture),
                        listadoDeCuotas[i,2].ToString("C", CultureInfo.CurrentCulture)
                        );
                }
                //Actualizo las sumas de las cuotas y los intereses, tambien obtenidos por metodos de la clase
                txtSumaDeCuotas.Texts = prestamo.getSumaDeCuotas().ToString("C", CultureInfo.CurrentCulture);
                txtSumaDeIntereses.Texts = prestamo.getSumaDeIntereses().ToString("C", CultureInfo.CurrentCulture);
        }
    }
}
