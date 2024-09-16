using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2.Models
{
    public class Reservation
    {
        private bool[] smokingSeats = new bool[5]; // Asientos 1-5
        private bool[] nonsmokingSeats = new bool[5]; // Asientos 6-10

        // Método para asignar un asiento basado en la preferencia del usuario
        public string AssignSeat(int preference, out bool changedSection)
        {
            bool seatAssigned = false;
            int seatNumber = 0;
            changedSection = false;

            // Verificar si la preferencia es para la sección de fumar
            if (preference == 1) // Sección de fumar
            {
                seatAssigned = TryAssignSeat(smokingSeats, out seatNumber, 1);
                if (!seatAssigned)
                {
                    // Si no hay asientos disponibles en la sección de fumar
                    if (AskToChangeSection())
                    {
                        changedSection = true;
                        seatAssigned = TryAssignSeat(nonsmokingSeats, out seatNumber, 6);
                        if (seatAssigned)
                        {
                            seatNumber += 5; // Ajustar el número del asiento para la sección de no fumar
                        }
                    }
                }
            }
            // Verificar si la preferencia es para la sección de no fumar
            else if (preference == 2) // Sección de no fumar
            {
                seatAssigned = TryAssignSeat(nonsmokingSeats, out seatNumber, 6);
                if (!seatAssigned)
                {
                    // Si no hay asientos disponibles en la sección de no fumar
                    if (AskToChangeSection())
                    {
                        changedSection = true;
                        seatAssigned = TryAssignSeat(smokingSeats, out seatNumber, 1);
                    }
                }
            }

            // Verificar si todos los asientos están ocupados
            if (!seatAssigned && AreAllSeatsFull())
            {
                return "All seats are fully booked. Next flight leaves in 3 hours.";
            }

            // Retornar el resultado basado en si se asignó un asiento o no
            if (seatAssigned)
            {
                return $"Boarding Pass: Seat {seatNumber} ({(preference == 1 ? "Smoking" : "Nonsmoking")})";
            }

            return "Next flight leaves in 3 hours.";
        }

        // Método para intentar asignar un asiento en una sección dada
        private bool TryAssignSeat(bool[] section, out int seatNumber, int startIndex)
        {
            seatNumber = 0;
            for (int i = 0; i < section.Length; i++)
            {
                if (!section[i])
                {
                    section[i] = true;
                    seatNumber = i + startIndex;
                    return true;
                }
            }
            return false;
        }

        // Método para preguntar al usuario si acepta cambiar de sección
        private bool AskToChangeSection()
        {
            DialogResult result = MessageBox.Show("The section you selected is full. Do you accept the change to the other section?", "Section Full", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }

        // Método para verificar si todos los asientos están llenos
        private bool AreAllSeatsFull()
        {
            return smokingSeats.All(seat => seat) && nonsmokingSeats.All(seat => seat);
        }
    }
}