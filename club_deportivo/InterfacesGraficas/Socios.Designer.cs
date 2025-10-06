namespace club_deportivo.InterfacesGraficas
{
    partial class frmSocios
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
            components = new System.ComponentModel.Container();
            btnVolver = new Button();
            dtgvSocios = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            TipoDoc = new DataGridViewTextBoxColumn();
            numDoc = new DataGridViewTextBoxColumn();
            fecha = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            conexionBindingSource = new BindingSource(components);
            btnAgregar = new Button();
            btnEliminar = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvSocios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)conexionBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(192, 0, 0);
            btnVolver.ForeColor = SystemColors.ButtonFace;
            btnVolver.Location = new Point(12, 12);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(154, 41);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            btnVolver.MouseLeave += btnVolver_MouseLeave;
            btnVolver.MouseMove += btnVolver_MouseMove;
            // 
            // dtgvSocios
            // 
            dtgvSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvSocios.Columns.AddRange(new DataGridViewColumn[] { Nombre, Apellido, TipoDoc, numDoc, fecha, Telefono, Email });
            dtgvSocios.Location = new Point(12, 138);
            dtgvSocios.Name = "dtgvSocios";
            dtgvSocios.Size = new Size(884, 240);
            dtgvSocios.TabIndex = 1;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.Width = 150;
            // 
            // Apellido
            // 
            Apellido.DataPropertyName = "Apellido";
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            Apellido.Width = 150;
            // 
            // TipoDoc
            // 
            TipoDoc.DataPropertyName = "TipoDni";
            TipoDoc.HeaderText = "Tipo de documento";
            TipoDoc.Name = "TipoDoc";
            TipoDoc.Width = 150;
            // 
            // numDoc
            // 
            numDoc.DataPropertyName = "NroDni";
            numDoc.HeaderText = "Número de documento";
            numDoc.Name = "numDoc";
            numDoc.Width = 150;
            // 
            // fecha
            // 
            fecha.DataPropertyName = "FechaNacimiento";
            fecha.HeaderText = "Fecha de nacimiento";
            fecha.Name = "fecha";
            fecha.Width = 150;
            // 
            // Telefono
            // 
            Telefono.DataPropertyName = "Telefono";
            Telefono.HeaderText = "Número de telefono";
            Telefono.Name = "Telefono";
            Telefono.Width = 150;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Direccion de email";
            Email.Name = "Email";
            Email.Width = 150;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(192, 0, 0);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(629, 392);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(133, 40);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(192, 0, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(768, 392);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(128, 40);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(690, 24);
            button1.Name = "button1";
            button1.Size = new Size(206, 41);
            button1.TabIndex = 4;
            button1.Text = "EMITIR LISTADO DE MOROSOS";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 0, 0);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(690, 82);
            button2.Name = "button2";
            button2.Size = new Size(206, 41);
            button2.TabIndex = 5;
            button2.Text = "CARNET";
            button2.UseVisualStyleBackColor = false;
            // 
            // frmSocios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 457);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(dtgvSocios);
            Controls.Add(btnVolver);
            Name = "frmSocios";
            Text = "Socios";
            Load += Socios_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvSocios).EndInit();
            ((System.ComponentModel.ISupportInitialize)conexionBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnVolver;
        private DataGridView dtgvSocios;
        private Button btnAgregar;
        private Button btnEliminar;
        private BindingSource conexionBindingSource;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn TipoDoc;
        private DataGridViewTextBoxColumn numDoc;
        private DataGridViewTextBoxColumn fecha;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Email;
        private Button button1;
        private Button button2;
    }
}