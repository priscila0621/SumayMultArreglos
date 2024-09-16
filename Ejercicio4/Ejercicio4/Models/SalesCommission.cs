using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.Models
{
    public class SalesCommission
    {
        private int[] salaryRanges = new int[9]; // Arreglo de contadores para los rangos

        public void CalculateSalaries(int sales)
        {
            // Calcular salario
            double salary = 200 + (sales * 0.09);

            // Truncar salario a entero
            int truncatedSalary = (int)salary;

            // Determinar el rango del salario y actualizar el contador correspondiente
            if (truncatedSalary >= 200 && truncatedSalary <= 299)
                salaryRanges[0]++;
            else if (truncatedSalary >= 300 && truncatedSalary <= 399)
                salaryRanges[1]++;
            else if (truncatedSalary >= 400 && truncatedSalary <= 499)
                salaryRanges[2]++;
            else if (truncatedSalary >= 500 && truncatedSalary <= 599)
                salaryRanges[3]++;
            else if (truncatedSalary >= 600 && truncatedSalary <= 699)
                salaryRanges[4]++;
            else if (truncatedSalary >= 700 && truncatedSalary <= 799)
                salaryRanges[5]++;
            else if (truncatedSalary >= 800 && truncatedSalary <= 899)
                salaryRanges[6]++;
            else if (truncatedSalary >= 900 && truncatedSalary <= 999)
                salaryRanges[7]++;
            else if (truncatedSalary >= 1000)
                salaryRanges[8]++;
        }

        // Método para obtener el arreglo de rangos
        public int[] GetSalaryRanges()
        {
            return salaryRanges;
        }
    }
}
