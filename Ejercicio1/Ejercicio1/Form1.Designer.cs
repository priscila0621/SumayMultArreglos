namespace Ejercicio1
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
            this.btnLanzar = new System.Windows.Forms.Button();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.ColumnSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFrequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblVerificar = new System.Windows.Forms.Label();
            this.lblSimulador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLanzar
            // 
            this.btnLanzar.Location = new System.Drawing.Point(82, 86);
            this.btnLanzar.Name = "btnLanzar";
            this.btnLanzar.Size = new System.Drawing.Size(213, 55);
            this.btnLanzar.TabIndex = 0;
            this.btnLanzar.Text = "Lanzar Dados";
            this.btnLanzar.UseVisualStyleBackColor = true;
            this.btnLanzar.Click += new System.EventHandler(this.btnLanzar_Click);
            // 
            // dgvResultados
            // 
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSum,
            this.ColumnFrequency});
            this.dgvResultados.Location = new System.Drawing.Point(67, 176);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.Size = new System.Drawing.Size(243, 164);
            this.dgvResultados.TabIndex = 1;
            this.dgvResultados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultados_CellContentClick);
            // 
            // ColumnSum
            // 
            this.ColumnSum.HeaderText = "Suma";
            this.ColumnSum.Name = "ColumnSum";
            // 
            // ColumnFrequency
            // 
            this.ColumnFrequency.HeaderText = "Frecuencia";
            this.ColumnFrequency.Name = "ColumnFrequency";
            // 
            // lblVerificar
            // 
            this.lblVerificar.AutoSize = true;
            this.lblVerificar.Location = new System.Drawing.Point(16, 374);
            this.lblVerificar.Name = "lblVerificar";
            this.lblVerificar.Size = new System.Drawing.Size(45, 13);
            this.lblVerificar.TabIndex = 2;
            this.lblVerificar.Text = "Verificar";
            this.lblVerificar.Click += new System.EventHandler(this.lblVerificar_Click);
            // 
            // lblSimulador
            // 
            this.lblSimulador.AutoSize = true;
            this.lblSimulador.Font = new System.Drawing.Font("Yu Gothic UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimulador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblSimulador.Location = new System.Drawing.Point(42, 32);
            this.lblSimulador.Name = "lblSimulador";
            this.lblSimulador.Size = new System.Drawing.Size(302, 21);
            this.lblSimulador.TabIndex = 3;
            this.lblSimulador.Text = "Simulador de lanzamiento de dos dados";
            this.lblSimulador.Click += new System.EventHandler(this.lblSimulador_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 450);
            this.Controls.Add(this.lblSimulador);
            this.Controls.Add(this.lblVerificar);
            this.Controls.Add(this.dgvResultados);
            this.Controls.Add(this.btnLanzar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLanzar;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFrequency;
        private System.Windows.Forms.Label lblVerificar;
        private System.Windows.Forms.Label lblSimulador;
    }
}

