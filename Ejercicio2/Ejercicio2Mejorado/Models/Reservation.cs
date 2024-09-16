using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Mejorado.Models
{
    public class Reservation
    {
        private bool[] seats = new bool[10]; // false indica que el asiento está disponible, true indica que está ocupado

        public Reservation()
        {
            for (int i = 0; i < seats.Length; i++)
            {
                seats[i] = false;
            }
        }

        public string AssignSeat(int preference, out bool fullSection)
        {
            fullSection = false; // Inicialmente asumimos que la sección no está llena

            if (preference == 1) // Sección de fumar (asientos 1-5)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (!seats[i])
                    {
                        seats[i] = true;
                        return $"Seat {i + 1} (Smoking) assigned.";
                    }
                }
                fullSection = true;
                return "Smoking section full.";
            }
            else if (preference == 2) // Sección de no fumar (asientos 6-10)
            {
                for (int i = 5; i < 10; i++)
                {
                    if (!seats[i])
                    {
                        seats[i] = true;
                        return $"Seat {i + 1} (Non-Smoking) assigned.";
                    }
                }
                fullSection = true;
                return "Non-Smoking section full.";
            }
            else
            {
                return "Invalid preference. Please select 1 for Smoking or 2 for Non-Smoking.";
            }
        }
    }
}
