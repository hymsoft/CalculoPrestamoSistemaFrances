using System;

namespace Negocio
{
    public class SistemaFrances
    {

        private double sumaDeCuotas = 0;
        private double sumaDeIntereses = 0;

        public double CuotaAPagar(double capital, double tasa, int periodoEnAnios, string frecuenciaDePagos)
        {
            //Calculos Iniciales
            int totalDeCuotas = TotalDeCuotas(periodoEnAnios, frecuenciaDePagos);
            int pagosPorAnio = PagosPorAnio(frecuenciaDePagos);
            double tasaEquivalente = TasaEquivalente(tasa, pagosPorAnio);
            double tasaUnoSobreCien = TasaUnoSobreCien(tasaEquivalente);

            return (capital * tasaUnoSobreCien) / (1 - Math.Pow(1 + tasaUnoSobreCien, -totalDeCuotas));
        }

        public double TasaEquivalente(double tasa, int pagosPorAnio)
        {
            return tasa / pagosPorAnio;
        }

        private double TasaUnoSobreCien(double tasa)
        {
            return tasa / 100;
        }

        public int PagosPorAnio(string frecuenciaDePagos)
        {
            //Selecciono la frecuencia de pagos de acuerdo a la sleccion del usuario en el combobox
            int pagos = 0;
            switch (frecuenciaDePagos)
            {
                case "Anual":
                    pagos = 1;
                    break;
                case "Semestral":
                    pagos = 2;
                    break;
                case "Cuatrimestral":
                    pagos = 3;
                    break;
                case "Trimestral":
                    pagos = 4;
                    break;
                case "Bimestral":
                    pagos = 6;
                    break;
                default:
                    pagos = 12;
                    break;
            }
            return pagos;
        }

        public int TotalDeCuotas(int periodoEnAnios, string frecuenciaDePagos)
        {
            //Devuelve el total de cuotas a pagar de acuerdo a la seleccion del usuario en el combobox
            int divisor = 0;
            switch (frecuenciaDePagos)
            {
                case "Anual":
                    divisor = 1;
                    break;
                case "Semestral":
                    divisor = 2;
                    break;
                case "Cuatrimestral":
                    divisor = 3;
                    break;
                case "Trimestral":
                    divisor = 4;
                    break;
                case "Bimestral":
                    divisor = 6;
                    break;
                default:
                    divisor = 12;
                    break;
            }
            return periodoEnAnios * divisor;
        }

        public double[,] ListadoDeCuotas(double capital, double interesEquivalente, int totalDeCuotas, double cuotaAPagar)
        {
            //Este método recibe los 4 valores obligatorios para el calculo de las cuotas
            //y devuelve un array, con todos los datos de las cuotas para ser cargados en un datagrid, por ejemplo
            double[,] listadoDeCuotas = new double[totalDeCuotas, 4];
            double capitalVivo = capital;
            double interesEquivalente_ = TasaUnoSobreCien(interesEquivalente);
            double interes = 0;
            double capitalAmortizado = 0;
            for (int i = 0; i < totalDeCuotas; i++)
            {
                //calculo el interes para el periodo
                interes = interesEquivalente_ * capital;
                //capital amortizado
                capitalAmortizado = cuotaAPagar - interes;
                capital -= capitalAmortizado;

                listadoDeCuotas[i, 0] = interes;
                listadoDeCuotas[i, 1] = capitalAmortizado;
                listadoDeCuotas[i, 2] = capital;
                sumaDeCuotas += cuotaAPagar;
                sumaDeIntereses += interes;
            }

            return listadoDeCuotas;
        }

        public double getSumaDeCuotas()
        {
            return sumaDeCuotas;
        }

        public double getSumaDeIntereses()
        {
            return sumaDeIntereses;
        }

    }
}
