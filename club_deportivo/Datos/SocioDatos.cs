
using MySql.Data.MySqlClient;
using club_deportivo.Entidades; // Asumiendo que Socio está aquí
using club_deportivo.Datos; // Para usar la clase Conexion
using System; // Para manejar excepciones

namespace club_deportivo.Datos
{
    public class SocioDatos
    {
        public bool InsertarSocio(Socio socio)
        {
            // La consulta INSERT SQL
            // **IMPORTANTE**: Ajusta el nombre de la tabla (Socio) y las columnas
            // para que coincidan con tu esquema de base de datos.
            string consulta = "INSERT INTO Socio (nombre, apellido, tipo_documento, fecha_nacimiento, " +
                              "numero_documento, telefono, email) " +
                              "VALUES (@nombre, @apellido, @tipoDoc, @fechaNac, @numDoc, @tel, @email)";

            MySqlConnection conexion = Conexion.CrearConexion();
            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            // 1. Añadir parámetros para prevenir inyección SQL y para tipado correcto
            comando.Parameters.AddWithValue("@nombre", socio.Nombre);
            comando.Parameters.AddWithValue("@apellido", socio.Apellido);
            comando.Parameters.AddWithValue("@tipoDoc", socio.TipoDocumento);
            // Formatear la fecha para MySQL (ejemplo)
            comando.Parameters.AddWithValue("@fechaNac", socio.FechaNacimiento.ToString("yyyy-MM-dd"));
            comando.Parameters.AddWithValue("@numDoc", socio.NumeroDocumento);
            comando.Parameters.AddWithValue("@tel", socio.Telefono);
            comando.Parameters.AddWithValue("@email", socio.Email);
            //comando.Parameters.AddWithValue("@tipoCliente", socio.TipoCliente);

            try
            {
                conexion.Open();
                int filasAfectadas = comando.ExecuteNonQuery();
                return filasAfectadas > 0; // Si es mayor a 0, la inserción fue exitosa
            }
            catch (MySqlException ex)
            {
                // Manejo de errores (por ejemplo, mostrar el error)
                System.Diagnostics.Debug.WriteLine($"Error al insertar socio: {ex.Message}");
                return false;
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }
    }
}