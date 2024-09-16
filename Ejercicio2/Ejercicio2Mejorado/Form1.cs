using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio2Mejorado.Models;

namespace Ejercicio2Mejorado
{
    public partial class Form1 : Form
    {
        private Reservation reservation = new Reservation();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAssignSeat_Click(object sender, EventArgs e)
        {
            int preference;

            if (rbSmoking.Checked)
            {
                preference = 1; // Smoking
            }
            else if (rbNonSmoking.Checked)
            {
                preference = 2; // Non-Smoking
            }
            else
            {
                lblResult.Text = "Please select a seating preference.";
                return;
            }

            // Intentar asignar el asiento en la preferencia seleccionada
            bool fullSection;
            string result = reservation.AssignSeat(preference, out fullSection);

            if (fullSection)
            {
                // Preguntar al usuario si acepta cambiar de sección
                DialogResult dialogResult = MessageBox.Show(
                    result + "\nDo you accept a seat in the other section?", // Mensaje de resultado con pregunta
                    "Seat Assignment", // Título del MessageBox
                    MessageBoxButtons.YesNo, // Botones de respuesta
                    MessageBoxIcon.Question // Icono del MessageBox
                );

                if (dialogResult == DialogResult.Yes)
                {
                    // Si el usuario acepta cambiar de sección, intentar asignar en la otra sección
                    int alternativePreference = (preference == 1) ? 2 : 1;
                    result = reservation.AssignSeat(alternativePreference, out fullSection);
                }
                else
                {
                    // Si el usuario no acepta cambiar de sección
                    result = "Next flight leaves in 3 hours.";
                }
            }

            // Mostrar el resultado final
            lblResult.Text = result;
        }
        }
}
