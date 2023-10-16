using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class TipoPersona : BaseModel
    {
        public string NombreTipoPersona { get; set; }
        public ICollection<Persona> Personas { get; set; }
    }
}