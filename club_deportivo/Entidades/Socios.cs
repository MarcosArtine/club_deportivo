using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace club_deportivo.Entidades
{
    public class Socio
    {
        // Propiedades del Socio, ajusta los tipos si es necesario
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string TipoDocumento { get; set; } // O int, si es un ID de tipo
        public DateTime FechaNacimiento { get; set; }
        public string NumeroDocumento { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string TipoCliente { get; set; } // O int, si es un ID de tipo
    }
}