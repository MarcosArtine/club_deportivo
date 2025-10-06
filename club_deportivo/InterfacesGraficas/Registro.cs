using club_deportivo.Datos;
using club_deportivo.Entidades;
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
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // 1. Validar datos (¡ESENCIAL!): Revisar que los campos no estén vacíos, que el formato sea correcto, etc.
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Debe completar al menos el nombre y apellido.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Asumiendo que los controles se llaman:
            // txtNombre, txtApellido, cmbTipoDocumento, dtpFechaNacimiento (DateTime Picker),
            // txtNumeroDocumento, txtNumeroTelefono, txtDireccionEmail, cmbTipoCliente

            try
            {
                // 2. Recoger datos del formulario y crear el objeto Socio
                Socio nuevoSocio = new Socio
                {
                    Nombre = txtNombre.Text.Trim(),
                    Apellido = txtApellido.Text.Trim(),
                    TipoDocumento = cmbTipoDoc.SelectedItem.ToString(), // Asumiendo que es un ComboBox
                    FechaNacimiento = dtpFechaNac.Value, // Asumiendo un control DateTimePicker
                    NumeroDocumento = txtNumDoc.Text.Trim(),
                    Telefono = txtTel.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    // TipoCliente = cmbTipoCliente.SelectedItem.ToString() //se requiere condicionar para dar numero de socio
                };

                // 3. Llamar a la capa de datos para insertar
                SocioDatos datos = new SocioDatos();
                bool insertado = datos.InsertarSocio(nuevoSocio);

                // 4. Mostrar resultado al usuario
                if (insertado)
                {
                    MessageBox.Show("Socio registrado exitosamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Opcional: Llamar a la función Limpiar() si la implementas para limpiar los campos
                }
                else
                {
                    MessageBox.Show("Error al intentar registrar el socio. Revise la conexión y los datos.", "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores generales (ej. formato de fecha incorrecto si no usas DateTimePicker, etc.)
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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