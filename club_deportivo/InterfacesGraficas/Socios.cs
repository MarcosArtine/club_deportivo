using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace club_deportivo.InterfacesGraficas
{
    public partial class frmSocios : Form
    {
        public frmSocios()
        {
            InitializeComponent();

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

        private void dgvSocios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Vamos al formulario Registro/
            // **¡IMPORTANTE!** Aquí le pasamos la referencia de la grilla (dtgvSocios)
            frmRegistro frRegistro = new frmRegistro(dtgvSocios); // Asegúrate que 'dtgvSocios' es el nombre de tu grilla
            frRegistro.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
