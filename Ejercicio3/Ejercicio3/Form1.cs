using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio3.Models;

namespace Ejercicio3
{
    public partial class SalesForm : Form
    {
        private SalesSummary salesSummary = new SalesSummary();
        public SalesForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddSale_Click(object sender, EventArgs e)
        {
            try
            {
                int vendor = int.Parse(tbVendor.Text);
                int product = int.Parse(tbProduct.Text);
                double amount = double.Parse(tbAmount.Text);

                salesSummary.AddSale(vendor, product, amount);
                MessageBox.Show("Venta añadida exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            dgvSalesReport.Rows.Clear();

            // Configura las columnas del DataGridView
            dgvSalesReport.Columns.Clear();
            dgvSalesReport.Columns.Add("Product", "Producto");
            for (int j = 1; j <= 4; j++) // Asumiendo 4 vendedores
            {
                dgvSalesReport.Columns.Add($"Vendor{j}", $"Vendedor {j}");
            }
            dgvSalesReport.Columns.Add("TotalProduct", "Total Producto");

            double[,] salesData = salesSummary.GetSalesData();
            double[] totalSalesByVendor = salesSummary.GetTotalSalesByVendor();
            double[] totalSalesByProduct = salesSummary.GetTotalSalesByProduct();

            // Añadir filas de productos con sus ventas
            for (int i = 0; i < salesData.GetLength(0); i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvSalesReport);

                // Configura el valor de la primera celda (nombre del producto)
                row.Cells[0].Value = $"Producto {i + 1}";

                // Rellena el resto de celdas con los datos de ventas por vendedor
                for (int j = 0; j < salesData.GetLength(1); j++)
                {
                    row.Cells[j + 1].Value = salesData[i, j].ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-US"));
                }

                // Configura el valor de la última celda de la fila (total por producto)
                row.Cells[salesData.GetLength(1) + 1].Value = totalSalesByProduct[i].ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-US"));

                // Añade la fila al DataGridView
                dgvSalesReport.Rows.Add(row);
            }

            // Añadir la fila de totales por vendedor
            DataGridViewRow totalRow = new DataGridViewRow();
            totalRow.CreateCells(dgvSalesReport);

            totalRow.Cells[0].Value = "Total";
            for (int j = 0; j < totalSalesByVendor.Length; j++)
            {
                totalRow.Cells[j + 1].Value = totalSalesByVendor[j].ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-US"));
            }
            totalRow.Cells[totalSalesByVendor.Length + 1].Value = salesSummary.GetGrandTotal().ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-US"));

            dgvSalesReport.Rows.Add(totalRow);
        }
    }
}
