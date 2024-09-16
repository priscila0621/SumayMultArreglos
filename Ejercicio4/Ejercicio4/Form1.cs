using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio4.Models;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        private SalesCommission salesCommission = new SalesCommission();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Intentar convertir el texto ingresado en el TextBox a un número entero
                int sales = int.Parse(tbSales.Text);

                // Calcular salarios y actualizar los contadores
                salesCommission.CalculateSalaries(sales);
                DisplayResults(); // Mostrar resultados
            }
            catch (FormatException)
            {
                // Mostrar un mensaje de error si la entrada no es un número válido
                MessageBox.Show("Por favor, ingrese un número válido para las ventas.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayResults()
        {
            int[] ranges = salesCommission.GetSalaryRanges();
            dgvResults.Rows.Clear();
            dgvResults.Rows.Add("$200-$299", ranges[0]);
            dgvResults.Rows.Add("$300-$399", ranges[1]);
            dgvResults.Rows.Add("$400-$499", ranges[2]);
            dgvResults.Rows.Add("$500-$599", ranges[3]);
            dgvResults.Rows.Add("$600-$699", ranges[4]);
            dgvResults.Rows.Add("$700-$799", ranges[5]);
            dgvResults.Rows.Add("$800-$899", ranges[6]);
            dgvResults.Rows.Add("$900-$999", ranges[7]);
            dgvResults.Rows.Add("$1000 o superior", ranges[8]);
        }
    }
}
