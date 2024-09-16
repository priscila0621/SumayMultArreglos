namespace Ejercicio2
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblOpcion1 = new System.Windows.Forms.Label();
            this.lblOpcion2 = new System.Windows.Forms.Label();
            this.tbPreference = new System.Windows.Forms.TextBox();
            this.btnAssign = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the Airline Reservation System! ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblOpcion1
            // 
            this.lblOpcion1.AutoSize = true;
            this.lblOpcion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpcion1.Location = new System.Drawing.Point(22, 58);
            this.lblOpcion1.Name = "lblOpcion1";
            this.lblOpcion1.Size = new System.Drawing.Size(171, 16);
            this.lblOpcion1.TabIndex = 1;
            this.lblOpcion1.Text = "Please type 1 for \"smoking\"";
            // 
            // lblOpcion2
            // 
            this.lblOpcion2.AutoSize = true;
            this.lblOpcion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpcion2.Location = new System.Drawing.Point(22, 85);
            this.lblOpcion2.Name = "lblOpcion2";
            this.lblOpcion2.Size = new System.Drawing.Size(193, 16);
            this.lblOpcion2.TabIndex = 2;
            this.lblOpcion2.Text = "Please type 2 for \"nonsmoking\"";
            // 
            // tbPreference
            // 
            this.tbPreference.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPreference.Location = new System.Drawing.Point(268, 58);
            this.tbPreference.Name = "tbPreference";
            this.tbPreference.Size = new System.Drawing.Size(73, 26);
            this.tbPreference.TabIndex = 8;
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(149, 135);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(93, 32);
            this.btnAssign.TabIndex = 9;
            this.btnAssign.Text = "Assign Seat";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(22, 208);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(46, 19);
            this.lblResult.TabIndex = 10;
            this.lblResult.Text = "Result";
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 281);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.tbPreference);
            this.Controls.Add(this.lblOpcion2);
            this.Controls.Add(this.lblOpcion1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOpcion1;
        private System.Windows.Forms.Label lblOpcion2;
        private System.Windows.Forms.TextBox tbPreference;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Label lblResult;
    }
}

