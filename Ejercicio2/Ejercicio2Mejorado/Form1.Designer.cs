namespace Ejercicio2Mejorado
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblOptions = new System.Windows.Forms.Label();
            this.rbSmoking = new System.Windows.Forms.RadioButton();
            this.rbNonSmoking = new System.Windows.Forms.RadioButton();
            this.btnAssignSeat = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(12, 21);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(321, 20);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to the Airline Reservation System! ";
            this.lblWelcome.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblOptions
            // 
            this.lblOptions.AutoSize = true;
            this.lblOptions.Location = new System.Drawing.Point(58, 58);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(232, 13);
            this.lblOptions.TabIndex = 1;
            this.lblOptions.Text = "Please select 1 for smoking or 2 for nonsmoking";
            // 
            // rbSmoking
            // 
            this.rbSmoking.AutoSize = true;
            this.rbSmoking.Location = new System.Drawing.Point(83, 93);
            this.rbSmoking.Name = "rbSmoking";
            this.rbSmoking.Size = new System.Drawing.Size(31, 17);
            this.rbSmoking.TabIndex = 2;
            this.rbSmoking.TabStop = true;
            this.rbSmoking.Text = "1";
            this.rbSmoking.UseVisualStyleBackColor = true;
            // 
            // rbNonSmoking
            // 
            this.rbNonSmoking.AutoSize = true;
            this.rbNonSmoking.Location = new System.Drawing.Point(216, 93);
            this.rbNonSmoking.Name = "rbNonSmoking";
            this.rbNonSmoking.Size = new System.Drawing.Size(31, 17);
            this.rbNonSmoking.TabIndex = 3;
            this.rbNonSmoking.TabStop = true;
            this.rbNonSmoking.Text = "2";
            this.rbNonSmoking.UseVisualStyleBackColor = true;
            // 
            // btnAssignSeat
            // 
            this.btnAssignSeat.Location = new System.Drawing.Point(124, 127);
            this.btnAssignSeat.Name = "btnAssignSeat";
            this.btnAssignSeat.Size = new System.Drawing.Size(82, 43);
            this.btnAssignSeat.TabIndex = 4;
            this.btnAssignSeat.Text = "Assign Seat";
            this.btnAssignSeat.UseVisualStyleBackColor = true;
            this.btnAssignSeat.Click += new System.EventHandler(this.btnAssignSeat_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(13, 185);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(7, 13);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 260);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnAssignSeat);
            this.Controls.Add(this.rbNonSmoking);
            this.Controls.Add(this.rbSmoking);
            this.Controls.Add(this.lblOptions);
            this.Controls.Add(this.lblWelcome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.RadioButton rbSmoking;
        private System.Windows.Forms.RadioButton rbNonSmoking;
        private System.Windows.Forms.Button btnAssignSeat;
        private System.Windows.Forms.Label lblResult;
    }
}

