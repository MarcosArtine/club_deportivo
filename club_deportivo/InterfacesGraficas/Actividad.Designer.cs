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
            dataGridView1 = new DataGridView();
            conexionBindingSource = new BindingSource(components);
            idActividad = new DataGridViewTextBoxColumn();
            nombreActividad = new DataGridViewTextBoxColumn();
            montoActividad = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)conexionBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idActividad, nombreActividad, montoActividad });
            dataGridView1.DataSource = conexionBindingSource;
            dataGridView1.Location = new Point(61, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(641, 239);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // conexionBindingSource
            // 
            conexionBindingSource.DataSource = typeof(Datos.Conexion);
            // 
            // idActividad
            // 
            idActividad.HeaderText = "Id";
            idActividad.Name = "idActividad";
            idActividad.Width = 200;
            // 
            // nombreActividad
            // 
            nombreActividad.HeaderText = "Actividad";
            nombreActividad.Name = "nombreActividad";
            nombreActividad.Width = 200;
            // 
            // montoActividad
            // 
            montoActividad.HeaderText = "costo";
            montoActividad.Name = "montoActividad";
            montoActividad.Width = 200;
            // 
            // frmActividad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Name = "frmActividad";
            Text = "Actividad";
            Load += frmActividad_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)conexionBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource conexionBindingSource;
        private DataGridViewTextBoxColumn idActividad;
        private DataGridViewTextBoxColumn nombreActividad;
        private DataGridViewTextBoxColumn montoActividad;
    }
}