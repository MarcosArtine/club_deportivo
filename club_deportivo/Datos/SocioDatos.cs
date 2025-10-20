
using club_deportivo.Datos; // Para usar la clase Conexion
using club_deportivo.Entidades; // Asumiendo que Socio está aquí
using MySql.Data.MySqlClient;
using System.Data; // Para DataTable
using System; // Para manejar excepciones

namespace club_deportivo.Datos
{
    public class SocioDatos
    {


        //método para eliminar un cliente(Socio o No Socio) por su DNI
        public bool EliminarCliente(string nroDni)
        {
            MySqlConnection sqlCon = null;
            MySqlTransaction transaccion = null;

            try
            {
                sqlCon = Conexion.CrearConexion();
                sqlCon.Open();
                transaccion = sqlCon.BeginTransaction(); // Iniciar transacción

                // Consulta DELETE que usa el NroDni para identificar la Persona a eliminar.
                string deleteQuery = @"
                    DELETE FROM Persona
                    WHERE NroDni = @NroDni;
                ";

                MySqlCommand comando = new MySqlCommand(deleteQuery, sqlCon, transaccion);
                comando.Parameters.AddWithValue("@NroDni", nroDni);

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    transaccion.Commit(); // Confirmar la eliminación
                    return true;
                }
                else
                {
                    transaccion.Rollback(); // Deshacer si no se eliminó ninguna fila
                    return false;
                }
            }
            catch (Exception ex)
            {
                transaccion?.Rollback(); // Deshacer ante cualquier excepción
                // Lanzar una excepción para que el formulario la pueda capturar y mostrar
                throw new Exception("Error al intentar eliminar el cliente de la base de datos.", ex);
            }
            finally
            {
                if (sqlCon != null && sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }


        //método para ejecutar un UPDATE en la base de datos
        public bool ActualizarSocio(Socio socio)
        {
            MySqlConnection sqlCon = null;

            try
            {
                sqlCon = Conexion.CrearConexion();
                sqlCon.Open();

                // **IMPORTANTE**: Necesitas el ID (PersonaID/SocioID) para un UPDATE seguro. 
                // Si solo usas DNI, asumes que el DNI nunca cambia y es único.

                // Ejemplo de consulta UPDATE (usando el DNI como clave)
                string updateQuery = @"
            UPDATE Persona SET 
                Nombre = @Nombre, 
                Apellido = @Apellido, 
                TipoDni = @TipoDni, 
                FechaNacimiento = @FechaNacimiento, 
                Telefono = @Telefono, 
                Email = @Email
            WHERE NroDni = @NroDni;
        ";

                MySqlCommand comando = new MySqlCommand(updateQuery, sqlCon);

                // Asignar parámetros
                comando.Parameters.AddWithValue("@Nombre", socio.Nombre);
                comando.Parameters.AddWithValue("@Apellido", socio.Apellido);
                comando.Parameters.AddWithValue("@TipoDni", socio.TipoDocumento);
                comando.Parameters.AddWithValue("@FechaNacimiento", socio.FechaNacimiento);
                comando.Parameters.AddWithValue("@Telefono", socio.Telefono);
                comando.Parameters.AddWithValue("@Email", socio.Email);
                comando.Parameters.AddWithValue("@NroDni", socio.NumeroDocumento); // Usado en el WHERE

                int filasAfectadas = comando.ExecuteNonQuery();

                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                // Propaga el error para que frmRegistro lo capture
                throw new Exception("Error al actualizar datos del socio en la base de datos.", ex);
            }
            finally
            {
                if (sqlCon != null && sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }


        // Método estatico para insertar un nuevo Socio (y los datos en la tabla Persona de la base de datos)
        public bool InsertarSocio(Socio socio)
        {
            MySqlConnection conexion = Conexion.CrearConexion(); // 
            MySqlTransaction transaccion = null; // Usaremos una transacción
            bool exito = false; // inicialmente la variable la ponemos como false

            try
            {
                conexion.Open(); // Abrir la conexión
                transaccion = conexion.BeginTransaction(); // Iniciar la transacción

                // Primero insertamos en Persona con una consulta sql
                string queryPersona = "INSERT INTO Persona (Nombre, Apellido, TipoDni, NroDni, FechaNacimiento, Telefono, Email) " +
                                      "VALUES (@nombre, @apellido, @tipoDoc, @numDoc, @fechaNac, @tel, @email); " +
                                      "SELECT LAST_INSERT_ID();"; // Obtener el ID generado

                // Preparar el comando para Persona y agregar parámetros
                MySqlCommand cmdPersona = new MySqlCommand(queryPersona, conexion, transaccion); // Asociar la transacción
                cmdPersona.Parameters.AddWithValue("@nombre", socio.Nombre); // 
                cmdPersona.Parameters.AddWithValue("@apellido", socio.Apellido);
                cmdPersona.Parameters.AddWithValue("@tipoDoc", socio.TipoDocumento);
                cmdPersona.Parameters.AddWithValue("@numDoc", socio.NumeroDocumento);
                cmdPersona.Parameters.AddWithValue("@fechaNac", socio.FechaNacimiento.ToString("yyyy-MM-dd"));
                cmdPersona.Parameters.AddWithValue("@tel", socio.Telefono);
                cmdPersona.Parameters.AddWithValue("@email", socio.Email);

                // Ejecutar y obtener el PersonaId que se acaba de insertar
                int personaId = Convert.ToInt32(cmdPersona.ExecuteScalar());

                // Aquí usaré la fecha actual como Fecha de Alta del Socio
                string fechaAlta = DateTime.Now.ToString("yyyy-MM-dd");

           
                string nroCarnetGenerado = personaId.ToString("D4"); // Formatear con ceros a la izquierda (5 dígitos)

                // Luego insertamos en Socio usando el PersonaId obtenido
                string querySocio = "INSERT INTO Socio (SocioId, FechaAltaSocio, NroCarnet) " +
                                    "VALUES (@socioId, @fechaAlta, @nroCarnet)";

                // Preparar el comando para Socio y agregar parámetros
                MySqlCommand cmdSocio = new MySqlCommand(querySocio, conexion, transaccion);
                cmdSocio.Parameters.AddWithValue("@socioId", personaId);
                cmdSocio.Parameters.AddWithValue("@fechaAlta", fechaAlta);
                cmdSocio.Parameters.AddWithValue("@nroCarnet", nroCarnetGenerado); // Usamos el generado aquí

                // Ejecutar el comando para Socio
                int filasSocio = cmdSocio.ExecuteNonQuery();

                // Si ambas inserciones fueron exitosas, confirmamos la transacción
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

                // Manejar errores específicos de MySQL
                throw new Exception("Error BD: " + ex.Message, ex);
            }
            catch (Exception ex)
            {
                // Si hay error, deshacer la operación
                transaccion?.Rollback();
                throw new Exception("Error General: " + ex.Message, ex);
            }
            finally
            {
                // Asegurarse de cerrar la conexión
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            // Retornar true si todo fue exitoso
            return exito;
        }
    }
}