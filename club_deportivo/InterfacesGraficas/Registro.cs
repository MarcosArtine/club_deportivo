using club_deportivo.Datos;
using club_deportivo.Entidades;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace club_deportivo.InterfacesGraficas
{
    public partial class frmRegistro : Form
    {
        // Nuevas variables para manejar el estado de Modificación
        private bool _esModificacion = false;
        private string _nroDniOriginal = string.Empty;


        // Constructor para AGREGAR (el original)
        public frmRegistro()
        {
            InitializeComponent();
        }

        // 🎯 Nuevo Constructor para MODIFICAR 🎯
        public frmRegistro(string nroDni) : this()
        {
            _esModificacion = true;
            _nroDniOriginal = nroDni;

            // Cambiar la interfaz para reflejar el modo Edición
            this.Text = "Modificar Registro de Cliente/Socio";
            btnAgregar.Text = "Guardar Cambios";

            // Bloquear el campo de DNI (clave primaria) para evitar inconsistencias
            txtNumDoc.Enabled = false;

            // Cargar los datos del registro en los controles
            CargarDatosCliente(nroDni);
        }

        private void CargarDatosCliente(string nroDni)
        {
            try
            {
                // **NOTA:** Necesitas un método BuscarSocioPorDni en tu capa de Entidades/Datos.
                E_Socio nSocio = new E_Socio();
                // Asumo que MostrarClientes() o un método similar puede devolver una fila filtrada por DNI
                DataTable dtCliente = nSocio.BuscarClientePorDni(nroDni);

                if (dtCliente.Rows.Count > 0)
                {
                    DataRow row = dtCliente.Rows[0];
                    txtNombre.Text = row["Nombre"].ToString();
                    txtApellido.Text = row["Apellido"].ToString();
                    cmbTipoDoc.SelectedItem = row["TipoDni"].ToString(); // Debe coincidir con los items
                    txtNumDoc.Text = row["NroDni"].ToString(); // Lo bloqueamos arriba, pero lo cargamos
                    txtTel.Text = row["Telefono"].ToString();
                    txtEmail.Text = row["Email"].ToString();

                    // Carga de Fecha de Nacimiento
                    if (row["FechaNacimiento"] != DBNull.Value)
                    {
                        dtpFechaNac.Value = (DateTime)row["FechaNacimiento"];
                    }

                    // Nota: No se puede cargar cbxActoFisico a menos que se almacene en la BD. 
                    // Si el acto físico no es modificable o no se guarda, se deja como está.
                    // Si se guarda en la DB: cbxActoFisico.Checked = Convert.ToBoolean(row["ActoFisico"]);
                }
                else
                {
                    MessageBox.Show("No se encontraron datos para el DNI proporcionado.", "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos del cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //VALIDACIÓN DEL CHECKBOX ACTO FISICO (aplica igual para ambos modos)
            if (!cbxActoFisico.Checked)
            {
                MessageBox.Show("No presentó el apto físico, no se puede continuar.", "Requisito Obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar datos (aplica igual para ambos modos)
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) || cmbTipoDoc.SelectedItem == null || string.IsNullOrWhiteSpace(txtNumDoc.Text))
            {
                MessageBox.Show("Debe completar todos los campos obligatorios.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            try
            {
                // Recoger datos del formulario en un objeto (Funciona para ambos modos)
                Socio clienteAOperar = new Socio
                {
                    // Nota: En modo modificación, el txtNumDoc.Text es igual a _nroDniOriginal 
                    // porque lo deshabilitamos arriba, asegurando la clave.
                    Nombre = txtNombre.Text.Trim(),
                    Apellido = txtApellido.Text.Trim(),
                    TipoDocumento = cmbTipoDoc.SelectedItem.ToString(),
                    FechaNacimiento = dtpFechaNac.Value,
                    NumeroDocumento = txtNumDoc.Text.Trim(), // Clave de identificación
                    Telefono = txtTel.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    // ... otros campos como ActoFisico si tu clase Socio los tiene
                };

                SocioDatos datos = new SocioDatos();
                bool operacionExitosa = false;
                string mensaje = "";

                if (_esModificacion)
                {
                    // 🎯 MODO MODIFICACIÓN 🎯
                    // El método ActualizarSocio debe usar clienteAOperar.NumeroDocumento 
                    // como clave WHERE, que es el _nroDniOriginal.
                    operacionExitosa = datos.ActualizarSocio(clienteAOperar);
                    mensaje = "Registro modificado exitosamente.";
                }
                else
                {
                    // 🚀 MODO AGREGAR (Original) 🚀
                    operacionExitosa = datos.InsertarSocio(clienteAOperar);
                    mensaje = "Socio registrado exitosamente.";
                }

                // Mostrar resultado al usuario
                if (operacionExitosa)
                {
                    MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 
                }
                else
                {
                    MessageBox.Show("Error al intentar realizar la operación. Revise la conexión y los datos.", "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            cmbTipoDoc.SelectedItem = null;
            dtpFechaNac.Value = DateTime.Now;
            txtNumDoc.Text = "";
            txtTel.Text = "";
            txtEmail.Text = "";
            cbxActoFisico.Checked = false; // Limpiar checkbox

            // En modo modificación, restaurar el DNI original y bloquearlo de nuevo
            if (_esModificacion)
            {
                txtNumDoc.Text = _nroDniOriginal;
                txtNumDoc.Enabled = false;
            }
            else
            {
                txtNumDoc.Enabled = true;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            /* Cerramos el formulario Registro*/
            this.Close();

            /* Regresamos al formulario Home*/
            frmPrincipal Home = new frmPrincipal();
            Home.Show();
        }
    }
}