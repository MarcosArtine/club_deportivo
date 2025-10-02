using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Windows.Forms; 

namespace club_deportivo.Datos
{
    public class EActividad
    {
        public DataTable Listar()
        {
            // Declarar y crear el DataTable que será devuelto
            DataTable DtResultado = new DataTable(); // <-- ¡Añade esta línea!

            // Usamos MySqlConnection para la conexión
            MySqlConnection Conex = new MySqlConnection();

            try
            {
                // Obtenemos la instancia de la conexión
                Conex = Conexion.getInstancia().CrearConcexion();

                // 🔑 ¡Importante! Abrir la conexión antes de usar el comando/adaptador
                Conex.Open(); // <-- (Recomendado de la respuesta anterior)

                // Creamos el comando SQL que se ejecutará
                MySqlCommand Comando = new MySqlCommand("SELECT * FROM actividad", Conex);
                Comando.CommandType = CommandType.Text;

                // Usamos MySqlDataAdapter para llenar el DataTable
                MySqlDataAdapter Adaptador = new MySqlDataAdapter(Comando);
                Adaptador.Fill(DtResultado); // Ahora DtResultado sí existe

            }
            catch (Exception ex)
            {
                // Si algo falla, cerramos la conexión y mostramos el error
                MessageBox.Show(ex.Message, "Error en la conexión a la base de datos",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null; // Devolvemos nulo en caso de error
            }
            finally
            {
                // Aseguramos que la conexión se cierre
                if (Conex.State == ConnectionState.Open) Conex.Close();
            }

            return DtResultado;
        }
    }
}