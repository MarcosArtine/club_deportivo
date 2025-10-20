using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using club_deportivo.Entidades;

namespace club_deportivo.InterfacesGraficas
{
    public partial class frmSocios : Form
    {
        int nro; // variable que se usan para cualquier procedimiento de este formulario

        public frmSocios()
        {
            InitializeComponent();

            // Cargar los datos en el DataGridView al iniciar el formulario
            ListarClientes();

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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmRegistro frRegistro = new frmRegistro();
            frRegistro.Show();
        }




        //Método para cargar los datos en el DataGrid
        private void ListarClientes()
        {
            try
            {
                E_Socio nSocio = new E_Socio();

                // Llama al nuevo método que trae todos
                DataTable dt = nSocio.MostrarClientes();

                this.dtgvSocios.DataSource = dt; // Asigna la tabla al DataGridView
                this.dtgvSocios.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells); // Ajusta el tamaño de las columnas


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar la grilla de clientes: " + ex.Message);
            }
        }

        private void dtgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nro = e.RowIndex; // muestra la posición de la fila seleccionada
            if (nro != -1)
            {
                MessageBox.Show("selecciono una fila");
                MessageBox.Show((string)dtgvSocios.Rows[nro].Cells
                [1].Value);
            }
            else
            {
                MessageBox.Show("selecciono el ENCABEZADO");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // nro almacena el índice de la fila seleccionada.
            // Aseguramos que se haya seleccionado una fila de datos (no el encabezado o la fila de nuevo registro).
            if (nro != -1 && nro < dtgvSocios.Rows.Count - 1)
            {
                // 1. Obtener el DNI y el nombre de la fila seleccionada
                string nroDni = dtgvSocios.Rows[nro].Cells["NumDoc"].Value.ToString();
                string nombreCompleto = dtgvSocios.Rows[nro].Cells["Nombre"].Value.ToString() + " " +
                                        dtgvSocios.Rows[nro].Cells["Apellido"].Value.ToString();

                // 2. Pedir confirmación al usuario
                DialogResult resultado = MessageBox.Show(
                    $"¿Está seguro de que desea eliminar a {nombreCompleto} (DNI: {nroDni})?",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        // Instanciar la clase de la capa de datos
                        // Asumo que SocioDatos está en club_deportivo.Datos
                        club_deportivo.Datos.SocioDatos datos = new club_deportivo.Datos.SocioDatos();

                        // 3. Llamar al método de eliminación
                        bool exito = datos.EliminarCliente(nroDni);

                        // 4. Mostrar resultado y actualizar la grilla
                        if (exito)
                        {
                            MessageBox.Show("Cliente eliminado exitosamente. ✅", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ListarClientes(); // Recargar la grilla para reflejar el cambio
                            nro = -1; // Deseleccionar la fila
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el cliente. Verifique que el DNI exista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al intentar eliminar el cliente: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila primero para eliminar el registro. ⚠️", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCarnet_Click(object sender, EventArgs e)
        {
        


                    // Crear y mostrar la ventana modal (frmCarnet)
                    frmCarnet modalCarnet = new frmCarnet();
                    modalCarnet.ShowDialog(); // ShowDialog() la hace modal y bloquea el formulario principal
        }


        //El método btnModificar_Click llama al nuevo constructor,
        //pasando el DNI de la fila seleccionada.
        private void btnModificar_Click(object sender, EventArgs e)
        {
            // nro almacena el índice de la fila seleccionada por DataGridViewCellEventArgs e en dtgvDatos_CellClick.
            // Aseguramos que se haya seleccionado una fila de datos (no el encabezado o ninguna).
            if (nro != -1 && nro < dtgvSocios.Rows.Count - 1) // El '-1' es para evitar la fila de nuevo registro si existe.
            {
                // Obtener el DNI de la fila seleccionada
                string nroDni = dtgvSocios.Rows[nro].Cells["NumDoc"].Value.ToString();

                // **Llamamos al nuevo constructor de modificación**
                frmRegistro frRegistroModif = new frmRegistro(nroDni);
                frRegistroModif.ShowDialog();

                ListarClientes(); // Recargar la grilla
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila primero para modificar el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
