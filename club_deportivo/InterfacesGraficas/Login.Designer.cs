namespace club_deportivo.InterfacesGraficas
{
    partial class frmLogin
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
            Label lblLogin;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            pnlLogin = new Panel();
            pictureBox1 = new PictureBox();
            lblLogin2 = new Label();
            btnIngresar = new Button();
            lblUsuario = new Label();
            lblContraseña = new Label();
            txtUsuario = new TextBox();
            txtPass = new TextBox();
            llblRecordar = new LinkLabel();
            lblLogin = new Label();
            pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.FromArgb(164, 17, 0);
            lblLogin.Location = new Point(402, 46);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(230, 30);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "SISTEMA DE GESTIÓN";
            // 
            // pnlLogin
            // 
            pnlLogin.BackColor = Color.FromArgb(164, 17, 0);
            pnlLogin.Controls.Add(pictureBox1);
            pnlLogin.Dock = DockStyle.Left;
            pnlLogin.Location = new Point(0, 0);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(217, 450);
            pnlLogin.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 113);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(217, 210);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblLogin2
            // 
            lblLogin2.AutoSize = true;
            lblLogin2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin2.Location = new Point(419, 85);
            lblLogin2.Name = "lblLogin2";
            lblLogin2.Size = new Size(171, 15);
            lblLogin2.TabIndex = 2;
            lblLogin2.Text = "Bienvenido/a ingresa tu cuenta";
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(164, 17, 0);
            btnIngresar.ForeColor = SystemColors.Control;
            btnIngresar.Location = new Point(402, 320);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(198, 49);
            btnIngresar.TabIndex = 3;
            btnIngresar.Text = "INICIAR SECCIÓN";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            btnIngresar.MouseLeave += btnIngresar_MouseLeave;
            btnIngresar.MouseMove += btnIngresar_MouseMove;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(402, 133);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(70, 27);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Usuario:";
            lblUsuario.UseCompatibleTextRendering = true;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContraseña.Location = new Point(402, 208);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(100, 21);
            lblContraseña.TabIndex = 5;
            lblContraseña.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(402, 163);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(198, 23);
            txtUsuario.TabIndex = 6;
            txtUsuario.Text = "Escribe tu nombre aquí...";
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(402, 232);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(198, 23);
            txtPass.TabIndex = 7;
            txtPass.Text = "Escribe tu contraseña aquí...";
            txtPass.Enter += txtPass_Enter;
            txtPass.Leave += txtPass_Leave;
            // 
            // llblRecordar
            // 
            llblRecordar.AutoSize = true;
            llblRecordar.Location = new Point(481, 272);
            llblRecordar.Name = "llblRecordar";
            llblRecordar.Size = new Size(119, 15);
            llblRecordar.TabIndex = 8;
            llblRecordar.TabStop = true;
            llblRecordar.Text = "Olvide mi contraseña";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(llblRecordar);
            Controls.Add(txtPass);
            Controls.Add(txtUsuario);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            Controls.Add(btnIngresar);
            Controls.Add(lblLogin2);
            Controls.Add(lblLogin);
            Controls.Add(pnlLogin);
            Name = "frmLogin";
            Text = "Login";
            pnlLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlLogin;
        private PictureBox pictureBox1;
        private Label lblLogin2;
        private Button btnIngresar;
        private Label lblUsuario;
        private Label lblContraseña;
        private TextBox txtUsuario;
        private TextBox txtPass;
        private LinkLabel llblRecordar;
    }
}