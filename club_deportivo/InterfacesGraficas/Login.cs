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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace club_deportivo.InterfacesGraficas
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            btnIngresar.BackColor = Color.FromArgb(164, 17, 0);
        }


        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            // Verifica si el texto es el placeholder
            if (txtUsuario.Text == "Escribe tu nombre aquí...")
            {
                txtUsuario.Text = ""; // Borra el texto
                txtUsuario.ForeColor = System.Drawing.Color.Black; // Restaura el color
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            // Si el usuario no escribió nada (el campo está vacío)
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Escribe tu nombre aquí..."; // Restaura el placeholder
                txtUsuario.ForeColor = System.Drawing.Color.Gray; // Restaura el color
            }
        }


        private void txtPass_Enter(object sender, EventArgs e)
        {
            // Verifica si el texto es el placeholder
            if (txtPass.Text == "Escribe tu contraseña aquí...")
            {
                txtPass.Text = ""; // Borra el texto
                txtPass.ForeColor = System.Drawing.Color.Black; // Restaura el color

                txtPass.UseSystemPasswordChar = true; // Activa el modo de contraseña camuflada
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            // Si el usuario no escribió nada (el campo está vacío)
            if (txtPass.Text == "")
            {
                txtPass.Text = "Escribe tu contraseña aquí..."; // Restaura el placeholder
                txtPass.ForeColor = System.Drawing.Color.Gray; // Restaura el color
            }
        }


        private void btnIngresar_MouseMove(object sender, MouseEventArgs e)
        {
            btnIngresar.BackColor = Color.FromArgb(200, 17, 0);
        }

        private void btnIngresar_MouseLeave(object sender, EventArgs e)
        {
            btnIngresar.BackColor = Color.FromArgb(164, 17, 0);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            DataTable tablaLogin = new DataTable(); // es la que recibe los datos desde el formulario
            Entidades.Usuarios dato = new Entidades.Usuarios(); // variable que contiene todas las caracteristicas de la clase
            tablaLogin = dato.Log_Usu(txtUsuario.Text, txtPass.Text);
            if (tablaLogin.Rows.Count > 0)
            {

                /* Ocultamos el formulario Login */
                this.Hide();

                /* Abrimos el formulario Pagos*/
                frmPrincipal Principal = new frmPrincipal();
                Principal.Show();


            }
            else
            {
                MessageBox.Show("Usuario y/o password incorrecto");
            }

        }
    }
}
