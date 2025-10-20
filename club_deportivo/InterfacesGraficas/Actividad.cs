using club_deportivo.Datos; // Importamos el namespace para usar E_Actividad
using club_deportivo.Entidades;
using System;
using System.Data;
using System.Windows.Forms;

namespace club_deportivo.InterfacesGraficas
{
    public partial class frmActividad : Form
    {
        public frmActividad()
        {
            InitializeComponent();

            ListarActividades();
        }

        // 1. Método para cargar los datos en el DataGridView
        private void ListarActividades()
        {
            try
            {
                // Instanciamos la clase de datos
                E_Actividad Datos = new E_Actividad();

                // Llamamos al método Listar y guardamos el resultado
                DataTable dt = Datos.Listar();

                if (dt != null)
                {
                    // Asignamos el DataTable como fuente de datos de la grilla
                    dtgvActividad.DataSource = dt;

                    // Opcional: Renombrar las columnas para hacerlas más amigables
                    dtgvActividad.Columns["ActividadId"].HeaderText = "ID";
                    dtgvActividad.Columns["NombreActividad"].HeaderText = "Nombre";
                    dtgvActividad.Columns["MontoActividad"].HeaderText = "Monto ($)";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();

            /* Regresamos al formulario Home*/
            frmPrincipal Home = new frmPrincipal();
            Home.Show();
        }
    }
}