using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace EZUni
{
    public partial class Form_calcularNota : Form
    {

        List<float> list = new List<float>(); // Lista donde se guardan los porcentajes de las evaluaciones
        int contador = 1; // Número de asignación para UI

        public Form_calcularNota()
        {
            InitializeComponent();
        }

        // Agrega nota a la lista
        private void btn_agregarNota_Click(object sender, EventArgs e)
        {
            try {

                // Guarda los valores ingresados como decimales

                float nota = float.Parse(txt_nota.Text, CultureInfo.InvariantCulture.NumberFormat);
                float valorPorcentual = float.Parse(txt_porcentaje.Text, CultureInfo.InvariantCulture.NumberFormat);

                float porcentajeObtenido = (nota * valorPorcentual) / 100; // Saca el porcentaje obtenido según la nota ingresada

                // Almacena el porcentaje obtenido dentro de la lista y aumenta el contador

                list.Add(porcentajeObtenido);
                contador++;
                lbl_evaluacion.Text = String.Format("Evaluación #{0}", contador);

            }
            catch (Exception ex) {

                MessageBox.Show("Ingrese valores válidos", "Error");

            }
        }

        // Suma todas los porcentajes guardados en la lista y muestra la nota final
        private void btn_calcularNota_Click(object sender, EventArgs e)
        {
            string notaString = list.Sum().ToString();
            MessageBox.Show(String.Format("Nota final: "+ notaString));
            this.Dispose();
        }

        // X de salida (UI)
        private void lbl_xSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}