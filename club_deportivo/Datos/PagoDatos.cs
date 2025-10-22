using club_deportivo.Datos; // Para usar la clase Conexion
using club_deportivo.Entidades; // Asumiendo que Socio está aquí
//using MySql.Data.MySqlClient;
using MySqlConnector; // Usamos MySqlConnector
using System.Data; // Para DataTable
using System; // Para manejar excepciones
using System.Text;

namespace club_deportivo.Datos
{
    public class PagoDatos
    {
        private Conexion cnx = Conexion.getInstancia();

        // El método InsertarNuevoPago ahora recibe el objeto DTO y devuelve un mensaje
        public string InsertarNuevoPago(PagoCuotaDTO pago)
        {
            MySqlConnection sqlCon = null;
            MySqlTransaction transaction = null;
            string resultado = "";

            try
            {
                sqlCon = Conexion.CrearConexion();
                sqlCon.Open();

                // 1. Iniciar la Transacción
                transaction = sqlCon.BeginTransaction();

                // --- 1. INSERT INTO PagoRealizado (Maestro) ---
                string queryPagoRealizado = @"
                    INSERT INTO PagoRealizado (FechaPago, MontoTotal, TipoConcepto, MedioPago, ReferenciaId) 
                    VALUES (NOW(), @monto, @tipoConcepto, @medioPago, @referenciaId);
                    SELECT LAST_INSERT_ID();";

                MySqlCommand comandoPagoRealizado = new MySqlCommand(queryPagoRealizado, sqlCon, transaction);
                comandoPagoRealizado.Parameters.AddWithValue("@monto", pago.MontoCuota);
                comandoPagoRealizado.Parameters.AddWithValue("@tipoConcepto", pago.TipoConcepto);
                comandoPagoRealizado.Parameters.AddWithValue("@medioPago", pago.MedioPago);
                comandoPagoRealizado.Parameters.AddWithValue("@referenciaId", pago.SocioId);

                // Ejecutar y obtener el ID del PagoRealizado insertado
                int pagoRealizadoId = Convert.ToInt32(comandoPagoRealizado.ExecuteScalar());

                // --- 2. INSERT INTO PagoCuota (Detalle) ---
                string queryPagoCuota = @"
                    INSERT INTO PagoCuota (SocioId, FechaVencimientoCuota, EstadoCuota, MontoCuota, MedioPago, PagoRealizadoId) 
                    VALUES (@socioId, @fechaVencimiento, @estado, @monto, @medioPago, @pagoRealizadoId);";

                MySqlCommand comandoPagoCuota = new MySqlCommand(queryPagoCuota, sqlCon, transaction);
                comandoPagoCuota.Parameters.AddWithValue("@socioId", pago.SocioId);
                comandoPagoCuota.Parameters.AddWithValue("@fechaVencimiento", pago.FechaVencimientoCuota);
                comandoPagoCuota.Parameters.AddWithValue("@estado", pago.EstadoCuota);
                comandoPagoCuota.Parameters.AddWithValue("@monto", pago.MontoCuota);
                comandoPagoCuota.Parameters.AddWithValue("@medioPago", pago.MedioPago);
                comandoPagoCuota.Parameters.AddWithValue("@pagoRealizadoId", pagoRealizadoId);

                // Ejecutar la inserción de la cuota
                comandoPagoCuota.ExecuteNonQuery();

                // 3. Confirmar la Transacción (si ambos INSERTs fueron exitosos)
                transaction.Commit();
                resultado = "OK";
            }
            catch (Exception ex)
            {
                // Si algo falla, hacer rollback
                try
                {
                    if (transaction != null)
                        transaction.Rollback();
                }
                catch (Exception rollbackEx)
                {
                    // Manejo del error en el rollback (raro, pero posible)
                    throw new Exception("Error al hacer rollback: " + rollbackEx.Message, rollbackEx);
                }
                resultado = "Error al insertar el pago: " + ex.Message;
            }
            finally
            {
                if (sqlCon != null && sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
            return resultado;
        }

        // El método ObtenerReporteGeneralPagos() permanece igual.

        // ... (Tu código existente para ObtenerReporteGeneralPagos va aquí) ...

        public DataTable ObtenerReporteGeneralPagos()
        {
            // ... (El código de tu método ObtenerReporteGeneralPagos va aquí) ...
            DataTable dt = new DataTable();
            MySqlConnection sqlCon = null;
            MySqlDataAdapter adaptador = null;

            // La consulta SQL unificada
            string query = @"
                (
                    -- Pagos de cuotas (Socios)
                    SELECT 
                        pr.PagoRealizadoId AS Comprobante,
                        pr.FechaPago,
                        pr.MontoTotal AS Monto,
                        pr.TipoConcepto AS Tipo,    
                        pr.MedioPago,
                        CONCAT(p.Nombre, ' ', p.Apellido) AS NombreCompleto,
                        'Socio' AS TipoPersona, 
                        pc.FechaVencimientoCuota AS Vencimiento,
                        NULL AS Actividad
                    FROM PagoRealizado pr
                    JOIN PagoCuota pc ON pr.PagoRealizadoId = pc.PagoRealizadoId 
                    JOIN Socio s ON pc.SocioId = s.SocioId
                    JOIN Persona p ON s.SocioId = p.PersonaId
                )
                UNION ALL
                (
                    -- Pagos Diarios (NoSocios)
                    SELECT 
                        pr.PagoRealizadoId AS Comprobante,
                        pr.FechaPago,
                        pr.MontoTotal AS Monto,
                        pr.TipoConcepto AS Tipo,    
                        pr.MedioPago,
                        CONCAT(p.Nombre, ' ', p.Apellido) AS NombreCompleto,
                        'NoSocio' AS TipoPersona, 
                        NULL AS Vencimiento,
                        a.NombreActividad AS Actividad
                    FROM PagoRealizado pr
                    JOIN PagoDiario pd ON pr.PagoRealizadoId = pd.PagoRealizadoId 
                    JOIN NoSocio ns ON pd.NoSocioId = ns.NoSocioId 
                    JOIN Persona p ON ns.NoSocioId = p.PersonaId
                    JOIN Actividad a ON pd.ActividadId = a.ActividadId
                )
                ORDER BY FechaPago DESC;
            ";

            try
            {
                sqlCon = Conexion.CrearConexion();

                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                adaptador = new MySqlDataAdapter(comando);
                sqlCon.Open();

                adaptador.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar el registro de pagos en la base de datos.", ex);
            }
            finally
            {
                if (sqlCon != null && sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
                if (adaptador != null)
                {
                    adaptador.Dispose();
                }
            }
            return dt;
        }

    }
}