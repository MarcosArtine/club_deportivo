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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
