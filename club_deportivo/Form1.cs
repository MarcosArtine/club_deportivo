using club_deportivo.InterfacesGraficas;

namespace club_deportivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSocios_Click(object sender, EventArgs e)
        {
            /* Ocultamos el formulario Home */
            this.Hide();

            /* Abrimos el formulario Socios*/
            frmSocios Socio = new frmSocios();
            Socio.Show();
        }
    }
}
