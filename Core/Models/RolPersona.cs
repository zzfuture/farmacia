using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class RolPersona : BaseModel
    {
        public string NombreRolPersona { get; set; }
        public ICollection<Persona> Personas { get; set; }
    }
}