using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Models
{
    internal class SalesSummary
    {
        private const int NUM_VENDORS = 4;
        private const int NUM_PRODUCTS = 5;

        // Arreglo para almacenar las ventas
        private double[,] sales = new double[NUM_PRODUCTS, NUM_VENDORS];

        // Método para agregar una venta
        public void AddSale(int vendor, int product, double amount)
        {
            if (vendor < 1 || vendor > NUM_VENDORS || product < 1 || product > NUM_PRODUCTS)
            {
                throw new ArgumentOutOfRangeException("El número del vendedor o del producto es inválido.");
            }

            sales[product - 1, vendor - 1] += amount;
        }

        // Método para obtener las ventas totales por vendedor
        public double[] GetTotalSalesByVendor()
        {
            double[] totals = new double[NUM_VENDORS];
            for (int j = 0; j < NUM_VENDORS; j++)
            {
                double total = 0;
                for (int i = 0; i < NUM_PRODUCTS; i++)
                {
                    total += sales[i, j];
                }
                totals[j] = total;
            }
            return totals;
        }

        // Método para obtener las ventas totales por producto
        public double[] GetTotalSalesByProduct()
        {
            double[] totals = new double[NUM_PRODUCTS];
            for (int i = 0; i < NUM_PRODUCTS; i++)
            {
                double total = 0;
                for (int j = 0; j < NUM_VENDORS; j++)
                {
                    total += sales[i, j];
                }
                totals[i] = total;
            }
            return totals;
        }

        // Método para obtener las ventas totales generales
        public double GetGrandTotal()
        {
            double total = 0;
            for (int i = 0; i < NUM_PRODUCTS; i++)
            {
                for (int j = 0; j < NUM_VENDORS; j++)
                {
                    total += sales[i, j];
                }
            }
            return total;
        }

        // Método para obtener los datos de ventas en formato tabular
        public double[,] GetSalesData()
        {
            return sales;
        }
    }
}
