using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class DiceSimulation
    {
        private Random random = new Random();
        private int[] frecuencias = new int[13]; // Para contar la frecuencia de las sumas

        // Método que simula el lanzamiento de los dados
        public void EjecutarSimulacion(int numTiradas)
        {
            Array.Clear(frecuencias, 0, frecuencias.Length); // Reiniciar las frecuencias antes de cada simulación
            for (int i = 0; i < numTiradas; i++)
            {
                int dado1 = TirarDado(); // Lanza el primer dado
                int dado2 = TirarDado(); // Lanza el segundo dado
                int suma = dado1 + dado2; // Calcula la suma de los dados
                frecuencias[suma]++; // Incrementa la frecuencia de esa suma
            }
        }

        // Método que simula el lanzamiento de un dado
        private int TirarDado()
        {
            return random.Next(1, 7); // Retorna un número aleatorio entre 1 y 6
        }

        // Método para obtener la frecuencia de una suma específica
        public int GetFrecuencia(int suma)
        {
            return frecuencias[suma]; // Retorna la frecuencia de una suma dada
        }

        // Método para calcular el porcentaje de la suma 7
        public double CalcularPorcentajeSumaSiete(int numTiradas)
        {
            return (frecuencias[7] / (double)numTiradas) * 100; // Calcula el porcentaje
        }
    }
}
