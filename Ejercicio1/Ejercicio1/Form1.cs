using Ejercicio1.Models; // Importa la clase DiceSimulation
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        private DiceSimulation simulacion;
        public Form1()
        {
            InitializeComponent();
            simulacion = new DiceSimulation(); // Crear una instancia de la clase DiceSimulation
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dgvResultados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblVerificar_Click(object sender, EventArgs e)
        {

        }

        private void btnLanzar_Click(object sender, EventArgs e)
        {
            // Ejecuta la simulación 36,000 veces
            simulacion.EjecutarSimulacion(36000);

            // Muestra los resultados en el DataGridView
            MostrarResultadosEnGrid();

            // Verifica y muestra si la suma 7 aparece aproximadamente 1/6 de las veces
            VerificarSumaSiete();
        }
        // Método para mostrar los resultados en el DataGridView
        private void MostrarResultadosEnGrid()
        {
            dgvResultados.Rows.Clear(); // Limpia las filas existentes

            for (int i = 2; i <= 12; i++)
            {
                // Añadir los valores de las sumas y frecuencias al DataGridView
                dgvResultados.Rows.Add(i, simulacion.GetFrecuencia(i));
            }
        }

        // Método para mostrar la verificación de la suma 7 en el label lblVerificar
        private void VerificarSumaSiete()
        {
            double porcentaje = simulacion.CalcularPorcentajeSumaSiete(36000); // Obtener el porcentaje
            lblVerificar.Text = $"La suma 7 apareció en {porcentaje:F2}% de las tiradas. (Esperado: ~16.67%)";
        }

        private void lblSimulador_Click(object sender, EventArgs e)
        {

        }
    }
}
