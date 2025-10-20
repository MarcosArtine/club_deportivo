using club_deportivo.InterfacesGraficas;

namespace club_deportivo
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();

            btnSocios.BackColor = Color.FromArgb(164, 17, 0);
            btnPagos.BackColor = Color.FromArgb(164, 17, 0);
            btnActividad.BackColor = Color.FromArgb(164, 17, 0);
            btnSalir.BackColor = Color.FromArgb(164, 17, 0);
            btnRegistro.BackColor = Color.FromArgb(164, 17, 0);
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            /* Ocultamos el formulario Home */
            this.Hide();

            /* Abrimos el formulario Registro*/
            frmRegistro Registro = new frmRegistro();
            Registro.Show();
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
            //this.Close();

            Application.Exit();
        }

        private void btnRegistro_MouseMove(object sender, MouseEventArgs e)
        {
            // Efecto hover
            btnRegistro.BackColor = Color.FromArgb(200, 17, 0);
        }

        private void btnRegistro_MouseLeave(object sender, EventArgs e)
        {
            btnRegistro.BackColor = Color.FromArgb(164, 17, 0);
        }

        private void btnSocios_MouseMove(object sender, MouseEventArgs e)
        {
            btnSocios.BackColor = Color.FromArgb(200, 17, 0);
        }

        private void btnSocios_MouseLeave(object sender, EventArgs e)
        {
            btnSocios.BackColor = Color.FromArgb(164, 17, 0);
        }


        private void btnPagos_MouseMove(object sender, MouseEventArgs e)
        {
            btnPagos.BackColor = Color.FromArgb(200, 17, 0);
        }

        private void btnPagos_MouseLeave(object sender, EventArgs e)
        {
            btnPagos.BackColor = Color.FromArgb(164, 17, 0);
        }

        private void btnActividad_MouseMove(object sender, MouseEventArgs e)
        {
            btnActividad.BackColor = Color.FromArgb(200, 17, 0);
        }

        private void btnActividad_MouseLeave(object sender, EventArgs e)
        {
            btnActividad.BackColor = Color.FromArgb(164, 17, 0);
        }

        private void btnSalir_MouseMove(object sender, MouseEventArgs e)
        {
            btnSalir.BackColor = Color.FromArgb(200, 17, 0);
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.FromArgb(164, 17, 0);
        }

    }
}