using club_deportivo.InterfacesGraficas;

namespace club_deportivo
{
    public partial class frmClubDeportivo : Form
    {
        public frmClubDeportivo()
        {
            InitializeComponent();
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
            /* Ocultamos el formulario Home */
            this.Hide();

            /* Abrimos el formulario Socios*/
            frmActividad Actividad = new frmActividad();
            Actividad.Show();
        }
        private void btnRegistro_Click(object sender, EventArgs e)
        {
            frmRegistro Registro = new frmRegistro();
            Registro.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

    }
}
