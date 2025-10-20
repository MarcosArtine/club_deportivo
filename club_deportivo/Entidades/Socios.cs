using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace club_deportivo.Entidades
{
    // Socio hereda de Persona
    public class Socio : Persona
    {
        // Propiedades de la clase base (Persona) expuestas como públicas
        // Utilizamos 'new' para ocultar la advertencia de que ocultan a los miembros de la clase base.
        // Esto permite que el resto del código que ya usaba las propiedades como 'public' siga funcionando.

        // Se re-declaran con 'new public' para ser accesibles como públicas fuera de la clase.
        public new string Nombre { get => base.Nombre; set => base.Nombre = value; }
        public new string Apellido { get => base.Apellido; set => base.Apellido = value; }
        public new string TipoDocumento { get => base.TipoDocumento; set => base.TipoDocumento = value; }
        public new string NumeroDocumento { get => base.NumeroDocumento; set => base.NumeroDocumento = value; }
        public new DateTime FechaNacimiento { get => base.FechaNacimiento; set => base.FechaNacimiento = value; }
        public new string Telefono { get => base.Telefono; set => base.Telefono = value; }
        public new string Email { get => base.Email; set => base.Email = value; }

        // Propiedades propias de Socio
        public DateTime FechaAltaSocio { get; set; }
        public string NroCarnet { get; set; }
    }
}