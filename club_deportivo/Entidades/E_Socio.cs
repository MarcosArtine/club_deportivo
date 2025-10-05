using System.Data;
using MySql.Data.MySqlClient;
using club_deportivo.Datos; 

namespace club_deportivo.Entidades
{
    public class E_Socio
    {
        // Método para obtener todas las Personas (Socios y No Socios)
        public DataTable MostrarClientes() // Renombramos el método para reflejar que trae a todos
        {
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = null;

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                // --- Consulta SQL para obtener TODOS los registros y clasificarlos ---
                string sqlQuery = @"
                    SELECT 
                        p.Nombre, 
                        p.Apellido, 
                        p.TipoDni, 
                        p.NroDni, 
                        p.FechaNacimiento, 
                        p.Telefono, 
                        p.Email,
                        -- Usamos CASE para determinar si es Socio, No Socio, o ninguno (Aunque en tu DB debe ser uno de los dos)
                        CASE 
                            WHEN s.SocioID IS NOT NULL THEN 'Socio'
                            WHEN ns.NoSocioID IS NOT NULL THEN 'No Socio'
                            ELSE 'Indefinido' -- Caso de seguridad por si hay una Persona sin registro en Socio/NoSocio
                        END AS TipoCliente,
                        s.NroCarnet  -- El NroCarnet solo existirá para los Socios
                    FROM 
                        Persona p 
                    LEFT JOIN 
                        Socio s ON p.PersonaID = s.SocioID -- Intenta unir con Socio
                    LEFT JOIN 
                        NoSocio ns ON p.PersonaID = ns.NoSocioID; -- Intenta unir con NoSocio
                    ";

                MySqlCommand comando = new MySqlCommand(sqlQuery, sqlCon);

                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                sqlCon.Open();

                adaptador.Fill(tabla);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al cargar la lista de clientes: " + ex.Message);
            }
            finally
            {
                if (sqlCon != null && sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
            return tabla;
        }
    }
}