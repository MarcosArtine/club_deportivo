using club_deportivo.InterfacesGraficas;

namespace club_deportivo
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            /* OCULTAMOS el formulario Home */
            this.Hide();

            /* Abrimos el formulario Pagos*/
            frmPagos Pago = new frmPagos();
            Pago.Show();
        }

        private void btnSocios_Click(object sender, EventArgs e)
        {
            /* Ocultamos el formulario Home */
            this.Hide();

            /* Abrimos el formulario Socios*/
            frmSocios Socio = new frmSocios();
            Socio.Show();
        }

        private void btnActividad_Click(object sender, EventArgs e)
        {
            /* OCULTAMOS el formulario Home */
            this.Hide();

            /* Abrimos el formulario Actividad*/
            frmActividad Actividad = new frmActividad();
            Actividad.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Aquí sí usamos Close(), ya que queremos terminar la aplicación.
            this.Close();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            // No hacemos nada, ya estamos en el formulario de inicio.
        }
    }
}