namespace club_deportivo.InterfacesGraficas
{
    partial class frmActividad
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
            dtgvActividad = new DataGridView();
            conexionBindingSource = new BindingSource(components);
            btnVolver = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvActividad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)conexionBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dtgvActividad
            // 
            dtgvActividad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvActividad.Location = new Point(12, 88);
            dtgvActividad.Name = "dtgvActividad";
            dtgvActividad.Size = new Size(935, 271);
            dtgvActividad.TabIndex = 0;
            // 
            // conexionBindingSource
            // 
            conexionBindingSource.DataSource = typeof(Datos.Conexion);
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(192, 0, 0);
            btnVolver.ForeColor = SystemColors.ButtonFace;
            btnVolver.Location = new Point(12, 12);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(154, 41);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(192, 0, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(800, 384);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(147, 44);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(192, 0, 0);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(607, 384);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(144, 44);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // frmActividad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 450);
            Controls.Add(btnAgregar);
            Controls.Add(btnEliminar);
            Controls.Add(btnVolver);
            Controls.Add(dtgvActividad);
            Name = "frmActividad";
            Text = "Actividad";
            ((System.ComponentModel.ISupportInitialize)dtgvActividad).EndInit();
            ((System.ComponentModel.ISupportInitialize)conexionBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgvActividad;
        private BindingSource conexionBindingSource;
        private Button btnVolver;
        private Button btnEliminar;
        private Button btnAgregar;
    }
}