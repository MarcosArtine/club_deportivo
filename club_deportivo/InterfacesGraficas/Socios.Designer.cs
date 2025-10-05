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
            TipoCliente = new DataGridViewTextBoxColumn();
            conexionBindingSource = new BindingSource(components);
            btnAgregar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvSocios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)conexionBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(192, 0, 0);
            btnVolver.ForeColor = SystemColors.ButtonFace;
            btnVolver.Location = new Point(12, 397);
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
            dtgvSocios.AutoGenerateColumns = false;
            dtgvSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvSocios.Columns.AddRange(new DataGridViewColumn[] { Nombre, Apellido, TipoDoc, numDoc, fecha, Telefono, Email, TipoCliente });
            dtgvSocios.DataSource = conexionBindingSource;
            dtgvSocios.Location = new Point(12, 39);
            dtgvSocios.Name = "dtgvSocios";
            dtgvSocios.Size = new Size(1054, 228);
            dtgvSocios.TabIndex = 1;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.Width = 150;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            Apellido.Width = 150;
            // 
            // TipoDoc
            // 
            TipoDoc.HeaderText = "Tipo de documento";
            TipoDoc.Name = "TipoDoc";
            TipoDoc.Width = 150;
            // 
            // numDoc
            // 
            numDoc.HeaderText = "Número de documento";
            numDoc.Name = "numDoc";
            numDoc.Width = 150;
            // 
            // fecha
            // 
            fecha.HeaderText = "Fecha de nacimiento";
            fecha.Name = "fecha";
            fecha.Width = 150;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Número de telefono";
            Telefono.Name = "Telefono";
            Telefono.Width = 150;
            // 
            // Email
            // 
            Email.HeaderText = "Direccion de email";
            Email.Name = "Email";
            Email.Width = 150;
            // 
            // TipoCliente
            // 
            TipoCliente.HeaderText = "Tipo de cliente";
            TipoCliente.Name = "TipoCliente";
            TipoCliente.Width = 150;
            // 
            // conexionBindingSource
            // 
            conexionBindingSource.DataSource = typeof(Datos.Conexion);
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(357, 311);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(565, 311);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // frmSocios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 450);
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
        private DataGridViewTextBoxColumn TipoCliente;
    }
}