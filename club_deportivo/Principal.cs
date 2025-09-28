using club_deportivo.InterfacesGraficas;

namespace club_deportivo
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            btnSocios.BackColor = Color.FromArgb(164, 17, 0);
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            /* Ocultamos el formulario Home */
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


        private void btnSocios_MouseMove(object sender, MouseEventArgs e)
        {
            btnSocios.BackColor = Color.FromArgb(200, 17, 0);
        }

        private void btnSocios_MouseLeave(object sender, EventArgs e)
        {
            btnSocios.BackColor = Color.FromArgb(164, 17, 0);
        }
    }
}