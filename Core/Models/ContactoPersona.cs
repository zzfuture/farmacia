using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class ContactoPersona : BaseModel
    {
        public string IdPersonaFk { get; set; }
        public Persona Personas { get; set; }
        public int IdTipoContactoFk { get; set; }
        public TipoContacto TipoContactos { get; set; }
    }
}