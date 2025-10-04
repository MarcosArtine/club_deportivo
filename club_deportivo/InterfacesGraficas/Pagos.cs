using club_deportivo.InterfacesGraficas;
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
    public partial class frmPagos : Form
    {
        public frmPagos()
        {
            InitializeComponent();
        }

        private void btnNuevoPago_Click(object sender, EventArgs e)
        {
            /* Abrimos el formulario Nuevo Pago*/
            frmNuevoPago NuevoPago = new frmNuevoPago();
            NuevoPago.Show();
        }

        private void llblVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /* Cerramos el formulario Pagos*/
            this.Close();

            /* Regresamos al formulario Home*/
            frmPrincipal Home = new frmPrincipal();
            Home.Show();
        }
    }
}