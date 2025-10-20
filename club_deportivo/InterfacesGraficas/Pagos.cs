using club_deportivo.Entidades;
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

            // Cargar los datos en el DataGridView al iniciar el formulario
            ListarPagos();
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();

            /* Regresamos al formulario Home*/
            frmPrincipal Home = new frmPrincipal();
            Home.Show();
        }



        //Método para cargar los datos en el DataGrid
        private void ListarPagos()
        {
            try
            {
                Pagos nPago = new Pagos();

                // Llama al nuevo método que trae todos
                DataTable dt = nPago.MostrarPagos();

                this.dtgvPagos.DataSource = dt; // Asigna la tabla al DataGridView
                this.dtgvPagos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells); // Ajusta el tamaño de las columnas


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar la grilla de pagos: " + ex.Message);
            }
        }


    }
}