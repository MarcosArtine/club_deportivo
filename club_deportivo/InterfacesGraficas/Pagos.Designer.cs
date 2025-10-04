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
            LinkLabel llblVolver;
            btnNuevoPago = new Button();
            llblVolver = new LinkLabel();
            SuspendLayout();
            // 
            // llblVolver
            // 
            llblVolver.ActiveLinkColor = Color.Black;
            llblVolver.AutoSize = true;
            llblVolver.BackColor = Color.FromArgb(164, 17, 0);
            llblVolver.ForeColor = SystemColors.AppWorkspace;
            llblVolver.LinkColor = Color.White;
            llblVolver.Location = new Point(26, 45);
            llblVolver.Name = "llblVolver";
            llblVolver.Size = new Size(74, 15);
            llblVolver.TabIndex = 4;
            llblVolver.TabStop = true;
            llblVolver.Text = "<--- VOLVER";
            llblVolver.VisitedLinkColor = Color.FromArgb(164, 17, 0);
            llblVolver.LinkClicked += llblVolver_LinkClicked;
            // 
            // btnNuevoPago
            // 
            btnNuevoPago.BackColor = Color.FromArgb(164, 17, 0);
            btnNuevoPago.ForeColor = Color.White;
            btnNuevoPago.Location = new Point(561, 27);
            btnNuevoPago.Name = "btnNuevoPago";
            btnNuevoPago.Size = new Size(172, 50);
            btnNuevoPago.TabIndex = 2;
            btnNuevoPago.Text = "Nuevo pago";
            btnNuevoPago.UseVisualStyleBackColor = false;
            btnNuevoPago.Click += btnNuevoPago_Click;
            // 
            // frmPagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(llblVolver);
            Controls.Add(btnNuevoPago);
            Name = "frmPagos";
            Text = "Pagos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNuevoPago;
    }
}