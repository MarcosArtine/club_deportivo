using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using club_deportivo.Datos;
//using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace club_deportivo.Entidades
{
    /// <summary>
    /// DTO => (Data Transfer Object): Esta clase es utilizada exclusivamente para
    /// empaquetar y transferir los datos de un nuevo pago desde la Capa de
    /// Gestion a la Capa de Datos, asegurando la consistencia de la información.
    /// </summary>
    
    public class PagoCuotaDTO
    {
        // Identificador del Socio que realiza el pago.
        public int SocioId { get; set; }

        // Monto abonado por el Socio.
        public decimal MontoCuota { get; set; }

        // Tipo de pago realizado ("Efectivo" o "Tarjeta Cuota").
        public string MedioPago { get; set; }

        // Fecha de vencimiento de la cuota pagada.
        public DateTime FechaVencimientoCuota { get; set; }

        // Estado que se asigna a la cuota (por defecto, "Pagado").
        public string EstadoCuota { get; set; } = "Pagado";

        // Concepto del pago (por defecto, "Cuota").
        public string TipoConcepto { get; set; } = "Cuota";
    }
}
