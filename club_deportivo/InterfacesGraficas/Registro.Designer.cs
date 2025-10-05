namespace club_deportivo.InterfacesGraficas
{
    partial class frmRegistro
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
            btnAgregar = new Button();
            lblNombre = new Label();
            lblApellido = new Label();
            lblTipoDoc = new Label();
            lblNumDoc = new Label();
            lblFecha = new Label();
            lblTelefono = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtNumDoc = new TextBox();
            txtFecha = new TextBox();
            txtTel = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            btnVolver = new Button();
            btnLimpiar = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(546, 286);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(20, 49);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(403, 49);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido";
            // 
            // lblTipoDoc
            // 
            lblTipoDoc.AutoSize = true;
            lblTipoDoc.Location = new Point(20, 101);
            lblTipoDoc.Name = "lblTipoDoc";
            lblTipoDoc.Size = new Size(111, 15);
            lblTipoDoc.TabIndex = 3;
            lblTipoDoc.Text = "Tipo de documento";
            // 
            // lblNumDoc
            // 
            lblNumDoc.AutoSize = true;
            lblNumDoc.Location = new Point(20, 157);
            lblNumDoc.Name = "lblNumDoc";
            lblNumDoc.Size = new Size(132, 15);
            lblNumDoc.TabIndex = 4;
            lblNumDoc.Text = "Numero de documento";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(403, 101);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(120, 15);
            lblFecha.TabIndex = 5;
            lblFecha.Text = "Fecha de  nacimiento";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(403, 157);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(114, 15);
            lblTelefono.TabIndex = 6;
            lblTelefono.Text = "Número de telefono";
            lblTelefono.TextAlign = ContentAlignment.BottomCenter;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(179, 41);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(186, 23);
            txtNombre.TabIndex = 7;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(546, 49);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(204, 23);
            txtApellido.TabIndex = 8;
            // 
            // txtNumDoc
            // 
            txtNumDoc.Location = new Point(546, 96);
            txtNumDoc.Name = "txtNumDoc";
            txtNumDoc.Size = new Size(204, 23);
            txtNumDoc.TabIndex = 10;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(179, 149);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(186, 23);
            txtFecha.TabIndex = 11;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(546, 149);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(204, 23);
            txtTel.TabIndex = 12;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(20, 216);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(105, 15);
            lblEmail.TabIndex = 13;
            lblEmail.Text = "Dirección de email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(179, 208);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(186, 23);
            txtEmail.TabIndex = 14;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(192, 0, 0);
            btnVolver.ForeColor = SystemColors.ButtonFace;
            btnVolver.Location = new Point(20, 384);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(154, 41);
            btnVolver.TabIndex = 18;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(675, 286);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 19;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Dni", "Pasaporte", "Libreta civica" });
            comboBox1.Location = new Point(179, 91);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(186, 23);
            comboBox1.TabIndex = 20;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Socio", "No socio" });
            comboBox2.Location = new Point(552, 206);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(403, 214);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 22;
            label1.Text = "Tipo de cliente";
            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(btnLimpiar);
            Controls.Add(btnVolver);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtTel);
            Controls.Add(txtFecha);
            Controls.Add(txtNumDoc);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblTelefono);
            Controls.Add(lblFecha);
            Controls.Add(lblNumDoc);
            Controls.Add(lblTipoDoc);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(btnAgregar);
            Name = "frmRegistro";
            Text = "Registro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblTipoDoc;
        private Label lblNumDoc;
        private Label lblFecha;
        private Label lblTelefono;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtNumDoc;
        private TextBox txtFecha;
        private TextBox txtTel;
        private Label lblEmail;
        private TextBox txtEmail;
        private Button btnVolver;
        private Button btnLimpiar;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label1;
    }
}