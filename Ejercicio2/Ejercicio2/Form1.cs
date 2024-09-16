using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio2.Models;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        private Reservation reservation = new Reservation(); // Instancia de la clase Reservation

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            int preference;
            bool changedSection;

            // Obtener la preferencia del usuario desde el TextBox
            if (int.TryParse(tbPreference.Text, out preference) && (preference == 1 || preference == 2))
            {
                // Asignar el asiento basado en la preferencia del usuario
                string result = reservation.AssignSeat(preference, out changedSection);
                lblResult.Text = result;
            }
            else
            {
                lblResult.Text = "Invalid input. Please enter 1 for smoking or 2 for nonsmoking.";
            }
    
        }
        private void lblResult_Click(object sender, EventArgs e)
        {

        }
    }
}


 