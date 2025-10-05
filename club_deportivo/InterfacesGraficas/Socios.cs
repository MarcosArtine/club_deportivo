using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using club_deportivo.Entidades;

namespace club_deportivo.InterfacesGraficas
{
    public partial class frmSocios : Form
    {
        public frmSocios()
        {
            InitializeComponent();

            // Cargar los datos en el DataGridView al iniciar el formulario
            ListarClientes();

            btnVolver.BackColor = Color.FromArgb(164, 17, 0);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();

            /* Regresamos al formulario Home*/
            frmPrincipal Home = new frmPrincipal();
            Home.Show();
        }

        private void btnVolver_MouseMove(object sender, MouseEventArgs e)
        {
            btnVolver.BackColor = Color.FromArgb(200, 17, 0);
        }

        private void btnVolver_MouseLeave(object sender, EventArgs e)
        {
            btnVolver.BackColor = Color.FromArgb(164, 17, 0);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmRegistro frRegistro = new frmRegistro(); 
            frRegistro.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }


        // --- Método para cargar los datos en el DataGridView (ahora clientes) ---
        private void ListarClientes()
        {
            try
            {
                E_Socio nSocio = new E_Socio();

                // Llama al nuevo método que trae todos
                DataTable dt = nSocio.MostrarClientes();

                this.dtgvSocios.DataSource = dt;
                this.dtgvSocios.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                // Opcional: Ajustar el orden de las columnas si es necesario.
                // Asegúrate de que TipoCliente sea visible y esté bien ubicado.

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar la grilla de clientes: " + ex.Message);
            }
        }


        // Llama al método de carga cuando el formulario se muestre por primera vez
        private void Socios_Load(object sender, EventArgs e)
        {
            // El método clave que debes llamar al cargar el formulario
            this.ListarClientes();
        }


    }
}
