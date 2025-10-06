namespace club_deportivo.InterfacesGraficas
{
    partial class frmPagos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnNuevoPago = new Button();
            btnVolver = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnNuevoPago
            // 
            btnNuevoPago.BackColor = Color.FromArgb(164, 17, 0);
            btnNuevoPago.ForeColor = Color.White;
            btnNuevoPago.Location = new Point(615, 12);
            btnNuevoPago.Name = "btnNuevoPago";
            btnNuevoPago.Size = new Size(173, 41);
            btnNuevoPago.TabIndex = 2;
            btnNuevoPago.Text = "NUEVO PAGO";
            btnNuevoPago.UseVisualStyleBackColor = false;
            btnNuevoPago.Click += btnNuevoPago_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(192, 0, 0);
            btnVolver.ForeColor = SystemColors.ButtonFace;
            btnVolver.Location = new Point(12, 12);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(154, 41);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 361);
            dataGridView1.TabIndex = 6;
            // 
            // frmPagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnVolver);
            Controls.Add(btnNuevoPago);
            Name = "frmPagos";
            Text = "Pagos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnNuevoPago;
        private Button btnVolver;
        private DataGridView dataGridView1;
    }
}