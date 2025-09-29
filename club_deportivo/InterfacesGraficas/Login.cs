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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            btnIngresar.BackColor = Color.FromArgb(164, 17, 0);
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
            btnIngresar.BackColor = Color.FromArgb(164, 17, 0);

            DataTable tablaLogin = new DataTable(); // es la que recibe los datos desde el formulario
            Entidades.Usuarios dato = new Entidades.Usuarios(); // variable que contiene todas las caracteristicas de la clase
            tablaLogin = dato.Log_Usu(txtUsuario.Text, txtPass.Text);
            if (tablaLogin.Rows.Count > 0)
            {
                // quiere decir que el resultado tiene 1 fila por lo que el usuario EXISTE
                MessageBox.Show("Ingreso exitoso");
            }
            else
            {
                MessageBox.Show("Usuario y/o password incorrecto");
            }

        }
    }
}
