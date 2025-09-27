namespace club_deportivo
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            pnlBarra = new Panel();
            btnSalir = new Button();
            btnActividad = new Button();
            btnSocios = new Button();
            btnPagos = new Button();
            btnInicio = new Button();
            btnRegistro = new Button();
            pictureBox = new PictureBox();
            pnlBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pnlBarra
            // 
            pnlBarra.BackColor = Color.FromArgb(164, 17, 0);
            pnlBarra.Controls.Add(btnSalir);
            pnlBarra.Controls.Add(btnActividad);
            pnlBarra.Controls.Add(btnSocios);
            pnlBarra.Controls.Add(btnPagos);
            pnlBarra.Controls.Add(btnInicio);
            pnlBarra.Dock = DockStyle.Left;
            pnlBarra.Location = new Point(0, 0);
            pnlBarra.Name = "pnlBarra";
            pnlBarra.Size = new Size(162, 450);
            pnlBarra.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(164, 17, 0);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(-4, 400);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(172, 50);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnActividad
            // 
            btnActividad.BackColor = Color.FromArgb(164, 17, 0);
            btnActividad.ForeColor = Color.White;
            btnActividad.Location = new Point(-7, 138);
            btnActividad.Name = "btnActividad";
            btnActividad.Size = new Size(172, 50);
            btnActividad.TabIndex = 3;
            btnActividad.Text = "ACTIVIDAD";
            btnActividad.UseVisualStyleBackColor = false;
            btnActividad.Click += btnActividad_Click;
            // 
            // btnSocios
            // 
            btnSocios.BackColor = Color.FromArgb(164, 17, 0);
            btnSocios.ForeColor = Color.White;
            btnSocios.Location = new Point(-7, 92);
            btnSocios.Name = "btnSocios";
            btnSocios.Size = new Size(172, 50);
            btnSocios.TabIndex = 2;
            btnSocios.Text = "SOCIOS";
            btnSocios.UseVisualStyleBackColor = false;
            btnSocios.Click += btnSocios_Click;
            // 
            // btnPagos
            // 
            btnPagos.BackColor = Color.FromArgb(164, 17, 0);
            btnPagos.ForeColor = Color.White;
            btnPagos.Location = new Point(-4, 47);
            btnPagos.Name = "btnPagos";
            btnPagos.Size = new Size(172, 50);
            btnPagos.TabIndex = 1;
            btnPagos.Text = "PAGOS";
            btnPagos.UseVisualStyleBackColor = false;
            btnPagos.Click += btnPagos_Click;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.FromArgb(164, 17, 0);
            btnInicio.ForeColor = Color.White;
            btnInicio.Location = new Point(-4, 0);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(172, 50);
            btnInicio.TabIndex = 0;
            btnInicio.Text = "INICIO";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // btnRegistro
            // 
            btnRegistro.BackColor = Color.FromArgb(164, 17, 0);
            btnRegistro.ForeColor = Color.White;
            btnRegistro.Location = new Point(616, 31);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(172, 50);
            btnRegistro.TabIndex = 1;
            btnRegistro.Text = "REGISTRO";
            btnRegistro.UseVisualStyleBackColor = false;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // pictureBox1
            // 
            pictureBox.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox.Location = new Point(325, 108);
            pictureBox.Name = "pictureBox1";
            pictureBox.Size = new Size(292, 233);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 2;
            pictureBox.TabStop = false;
            // 
            // frmClubDeportivo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox);
            Controls.Add(btnRegistro);
            Controls.Add(pnlBarra);
            Name = "frmClubDeportivo";
            Text = "Club Deportivo";
            pnlBarra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBarra;
        private Button btnSalir;
        private Button btnActividad;
        private Button btnSocios;
        private Button btnPagos;
        private Button btnInicio;
        private Button btnRegistro;
        private PictureBox pictureBox;
    }
}
