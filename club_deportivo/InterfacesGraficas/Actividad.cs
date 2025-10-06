using club_deportivo.Datos; // Importamos el namespace para usar E_Actividad
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
                    dataGridView1.DataSource = dt;

                    // Opcional: Renombrar las columnas para hacerlas más amigables
                    dataGridView1.Columns["idActividad"].HeaderText = "ID";
                    dataGridView1.Columns["nombreActividad"].HeaderText = "Nombre";
                    dataGridView1.Columns["montoActividad"].HeaderText = "Monto ($)";

                    // Opcional: Ajustar el ancho de las columnas
                    dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // 2. Evento Load del formulario para cargar los datos automáticamente
        private void frmActividad_Load(object sender, EventArgs e)
        {
            ListarActividades();
        }

        // Evento que ya estaba en tu código
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Puedes dejarlo vacío o usarlo para manejar clics
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