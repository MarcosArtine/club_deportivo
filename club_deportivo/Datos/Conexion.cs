using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Referencia a MySQL (se agrega como libreria)
using MySql.Data.MySqlClient;


namespace club_deportivo.Datos
{
    public class Conexion // la clase debe ser PUBLICA
    {
        // declaramos las variables
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion? con = null;
        private Conexion() // asignamos valores a las variables de la conexion
        {
        this.baseDatos = "Proyecto";
        this.servidor = "localhost";
        this.puerto = "3306";
        this.usuario = "root";
        this.clave = "05abril1992";
        }
        // proceso de interacción
        public static MySqlConnection CrearConexion() // AÑADIR 'static'
        {
            // Obtener la única instancia de la conexión Singleton
            Conexion instancia = getInstancia();

            MySqlConnection? cadena = new MySqlConnection();

            try
            {
                cadena.ConnectionString = "datasource=" + instancia.servidor + // Usar la instancia
                ";port=" + instancia.puerto +
                ";username=" + instancia.usuario +
                ";password=" + instancia.clave +
                ";Database=" + instancia.baseDatos;
            }
            catch (Exception ex)
            {
                cadena = null;
                System.Windows.Forms.MessageBox.Show("Error al cargar la lista de clientes: " + ex.Message);
                throw;
            }
            return cadena;
        }


        // para evaluar la instancia de la conectividad
        public static Conexion getInstancia()
        {
            if (con == null) // quiere decir que la conexion esta cerrada
            {
                con = new Conexion(); // se crea una nueva
            }
            return con;
        }
    }
}