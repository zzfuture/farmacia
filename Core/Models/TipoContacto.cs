using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class TipoContacto : BaseModel
    {
        public string NombreTipoContacto { get; set; }
        public ICollection<ContactoPersona> ContactoPersonas { get; set; }
    }
}