
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
            MySqlConnection conexion = Conexion.CrearConexion();
            MySqlTransaction transaccion = null; // Usaremos una transacción
            bool exito = false;

            try
            {
                conexion.Open();
                transaccion = conexion.BeginTransaction(); // Iniciar la transacción

                string queryPersona = "INSERT INTO Persona (Nombre, Apellido, TipoDni, NroDni, FechaNacimiento, Telefono, Email) " +
                                      "VALUES (@nombre, @apellido, @tipoDoc, @numDoc, @fechaNac, @tel, @email); " +
                                      "SELECT LAST_INSERT_ID();"; // Obtener el ID generado

                MySqlCommand cmdPersona = new MySqlCommand(queryPersona, conexion, transaccion);
                cmdPersona.Parameters.AddWithValue("@nombre", socio.Nombre);
                cmdPersona.Parameters.AddWithValue("@apellido", socio.Apellido);
                cmdPersona.Parameters.AddWithValue("@tipoDoc", socio.TipoDocumento);
                cmdPersona.Parameters.AddWithValue("@numDoc", socio.NumeroDocumento);
                cmdPersona.Parameters.AddWithValue("@fechaNac", socio.FechaNacimiento.ToString("yyyy-MM-dd"));
                cmdPersona.Parameters.AddWithValue("@tel", socio.Telefono);
                cmdPersona.Parameters.AddWithValue("@email", socio.Email);

                // Ejecutar y obtener el PersonaId (LAST_INSERT_ID())
                int personaId = Convert.ToInt32(cmdPersona.ExecuteScalar());

                // Aquí usaré la fecha actual como FechaAltaSocio
                string fechaAlta = DateTime.Now.ToString("yyyy-MM-dd");

           
                string nroCarnetGenerado = personaId.ToString("D5"); 

                string querySocio = "INSERT INTO Socio (SocioId, FechaAltaSocio, NroCarnet) " +
                                    "VALUES (@socioId, @fechaAlta, @nroCarnet)";

                MySqlCommand cmdSocio = new MySqlCommand(querySocio, conexion, transaccion);
                cmdSocio.Parameters.AddWithValue("@socioId", personaId);
                cmdSocio.Parameters.AddWithValue("@fechaAlta", fechaAlta);
                cmdSocio.Parameters.AddWithValue("@nroCarnet", nroCarnetGenerado); // Usamos el generado

                int filasSocio = cmdSocio.ExecuteNonQuery();

                if (filasSocio > 0)
                {
                    transaccion.Commit(); // Confirmar ambas inserciones
                    exito = true;
                }
                else
                {
                    transaccion.Rollback(); // Deshacer si la segunda parte falla
                }
            }
            catch (MySqlException ex)
            {
                // Si hay error, deshacer la operación
                transaccion?.Rollback();

   
                throw new Exception("Error BD: " + ex.Message, ex);
            }
            catch (Exception ex)
            {
                transaccion?.Rollback();
                throw new Exception("Error General: " + ex.Message, ex);
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return exito;
        }
    }
}