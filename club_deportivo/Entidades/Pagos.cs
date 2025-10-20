using club_deportivo.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace club_deportivo.Entidades
{
    internal class Pagos
    {


        // Método para obtener los pagos de todos los Clientes (Socios y No Socios)
        public DataTable MostrarPagos() 
        {
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = null;

            try
            {
                sqlCon = Conexion.CrearConexion();

                // --- Consulta SQL para obtener los pagos ---
                string sqlQuery = @"
                   SELECT 
                        p.Nombre, 
                        p.Apellido, 
                        p.TipoDni, 
                        p.NroDni, 
                        p.FechaNacimiento, 
                        p.Telefono, 
                        p.Email,

                        
                        CASE 
                            WHEN s.SocioID IS NOT NULL THEN 'Socio' 
                            ELSE 'No Socio' 
                        END AS TipoCliente, 
                        s.NroCarnet  -- El NroCarnet solo existirá para los Socios
                    FROM 
                        Persona p 
                    LEFT JOIN 
                        Socio s ON p.PersonaID = s.SocioID
                    LEFT JOIN 
                        NoSocio ns ON p.PersonaID = ns.NoSocioID;
                    ";

                MySqlCommand comando = new MySqlCommand(sqlQuery, sqlCon);

                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                sqlCon.Open();

                adaptador.Fill(tabla);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al cargar la lista de pagos: " + ex.Message);
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
