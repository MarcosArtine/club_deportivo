using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace club_deportivo.Entidades
{
    public class Persona
    {
        // Las propiedades es 'protected' para que sean accesibles por la clase hija 'Socio'.

        protected string Nombre { get; set; }
        protected string Apellido { get; set; }
        protected string TipoDocumento { get; set; } 
        protected string NumeroDocumento { get; set; }
        protected DateTime FechaNacimiento { get; set; }
        protected string Telefono { get; set; }
        protected string Email { get; set; }
    }
}