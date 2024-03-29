using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Departamento : BaseModel
    {
        public string NombreDepartamento { get; set; }
        public int IdPaisFk { get; set; }
        public Pais Paises { get; set; }
        public ICollection<Ciudad> Ciudades { get; set; }
    }
}