namespace club_deportivo
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            pnlBarra = new Panel();
            btnLogin = new Button();
            btnSalir = new Button();
            btnActividad = new Button();
            btnSocios = new Button();
            btnPagos = new Button();
            btnRegistro = new Button();
            pictureBox = new PictureBox();
            pnlBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pnlBarra
            // 
            pnlBarra.BackColor = Color.FromArgb(164, 17, 0);
            pnlBarra.Controls.Add(btnLogin);
            pnlBarra.Controls.Add(btnSalir);
            pnlBarra.Controls.Add(btnActividad);
            pnlBarra.Controls.Add(btnSocios);
            pnlBarra.Controls.Add(btnPagos);
            pnlBarra.Dock = DockStyle.Left;
            pnlBarra.Location = new Point(0, 0);
            pnlBarra.Name = "pnlBarra";
            pnlBarra.Size = new Size(162, 450);
            pnlBarra.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(40, 12);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
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
            btnSalir.MouseLeave += btnSalir_MouseLeave;
            btnSalir.MouseMove += btnSalir_MouseMove;
            // 
            // btnActividad
            // 
            btnActividad.BackColor = Color.FromArgb(164, 17, 0);
            btnActividad.ForeColor = Color.White;
            btnActividad.Image = (Image)resources.GetObject("btnActividad.Image");
            btnActividad.ImageAlign = ContentAlignment.MiddleLeft;
            btnActividad.Location = new Point(-7, 138);
            btnActividad.Name = "btnActividad";
            btnActividad.Size = new Size(172, 50);
            btnActividad.TabIndex = 3;
            btnActividad.Text = "      ACTIVIDAD";
            btnActividad.UseVisualStyleBackColor = false;
            btnActividad.Click += btnActividad_Click;
            btnActividad.MouseLeave += btnActividad_MouseLeave;
            btnActividad.MouseMove += btnActividad_MouseMove;
            // 
            // btnSocios
            // 
            btnSocios.BackColor = Color.FromArgb(164, 17, 0);
            btnSocios.ForeColor = Color.White;
            btnSocios.Image = (Image)resources.GetObject("btnSocios.Image");
            btnSocios.ImageAlign = ContentAlignment.MiddleLeft;
            btnSocios.Location = new Point(-4, 94);
            btnSocios.Name = "btnSocios";
            btnSocios.Size = new Size(169, 50);
            btnSocios.TabIndex = 2;
            btnSocios.Text = " SOCIOS";
            btnSocios.UseVisualStyleBackColor = false;
            btnSocios.Click += btnSocios_Click;
            btnSocios.MouseLeave += btnSocios_MouseLeave;
            btnSocios.MouseMove += btnSocios_MouseMove;
            // 
            // btnPagos
            // 
            btnPagos.BackColor = Color.FromArgb(164, 17, 0);
            btnPagos.ForeColor = Color.White;
            btnPagos.Image = (Image)resources.GetObject("btnPagos.Image");
            btnPagos.ImageAlign = ContentAlignment.MiddleLeft;
            btnPagos.Location = new Point(-4, 47);
            btnPagos.Name = "btnPagos";
            btnPagos.Size = new Size(172, 50);
            btnPagos.TabIndex = 1;
            btnPagos.Text = "PAGOS";
            btnPagos.UseVisualStyleBackColor = false;
            btnPagos.Click += btnPagos_Click;
            btnPagos.MouseLeave += btnPagos_MouseLeave;
            btnPagos.MouseMove += btnPagos_MouseMove;
            // 
            // btnRegistro
            // 
            btnRegistro.BackColor = Color.FromArgb(164, 17, 0);
            btnRegistro.ForeColor = Color.White;
            btnRegistro.Location = new Point(651, 22);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(137, 36);
            btnRegistro.TabIndex = 1;
            btnRegistro.Text = "REGISTRO";
            btnRegistro.UseVisualStyleBackColor = false;
            btnRegistro.MouseLeave += btnRegistro_MouseLeave;
            btnRegistro.MouseMove += btnRegistro_MouseMove;
            // 
            // pictureBox
            // 
            pictureBox.Image = (Image)resources.GetObject("pictureBox.Image");
            pictureBox.Location = new Point(305, 94);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(346, 298);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 2;
            pictureBox.TabStop = false;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox);
            Controls.Add(btnRegistro);
            Controls.Add(pnlBarra);
            Name = "frmPrincipal";
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
        private Button btnRegistro;
        private PictureBox pictureBox;
        private Button btnLogin;
    }
}
