using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class TipoDocumento : BaseModel
    {
        public string NombreTipoDocumento { get; set; }
        public ICollection<Persona> Personas { get; set; }
    }
}