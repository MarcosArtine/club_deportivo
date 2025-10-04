using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using club_deportivo.InterfacesGraficas;

namespace club_deportivo.InterfacesGraficas
{
    public partial class frmRegistro : Form
    {
        // Campo privado para guardar la referencia a la grilla
        private DataGridView _dtgvSocios;

        // Constructor que recibe el DataGridView como argumento
        public frmRegistro(DataGridView dtgvSocios)
        {
            InitializeComponent();

            // Asignar el parámetro recibido (dtgvSocios) al campo privado (_dtgvSocios)
            _dtgvSocios = dtgvSocios;
        }

        // Si necesitas poder abrir el formulario sin pasar la grilla (por ejemplo, si es llamado desde otro lugar), 
        // puedes mantener el constructor sin argumentos (el que se crea por defecto).
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // **IMPORTANTE:** Verificar que la grilla haya sido pasada correctamente
            if (_dtgvSocios != null)
            {
                // Agregamos un renglon para la escritura
                int renglon = _dtgvSocios.Rows.Add();
                // colocamos los datos en las columnas de esa fila
                _dtgvSocios.Rows[renglon].Cells[0].Value = txtNombre.Text;
                _dtgvSocios.Rows[renglon].Cells[1].Value = txtApellido.Text;
                _dtgvSocios.Rows[renglon].Cells[2].Value = txtTipoDoc.Text;
                _dtgvSocios.Rows[renglon].Cells[3].Value = txtNumDoc.Text;
                _dtgvSocios.Rows[renglon].Cells[4].Value = txtFecha.Text;
                _dtgvSocios.Rows[renglon].Cells[5].Value = txtTel.Text;
                _dtgvSocios.Rows[renglon].Cells[6].Value = txtEmail.Text;

                // blanqueo de los textBox
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtTipoDoc.Text = "";
                txtNumDoc.Text = "";
                txtFecha.Text = "";
                txtTel.Text = "";
                txtEmail.Text = "";

                // el foco se instala en el objeto
                txtNombre.Focus();

                // Opcional: Cierra el formulario de registro después de agregar
                this.Close();
            }
            else
            {
                MessageBox.Show("Error: La grilla de socios no ha sido cargada correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            /* Cerramos el formulario Registro*/
            this.Close();

            /* Regresamos al formulario Home*/
            frmPrincipal Home = new frmPrincipal();
            Home.Show();
        }

    }
}