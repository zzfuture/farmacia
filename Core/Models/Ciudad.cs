using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Ciudad : BaseModel
    {
        public string NombreCiudad { get; set; }
        public int IdDepartamentoFk { get; set; }
        public Departamento Departamentos { get; set; }
        public ICollection<UbicacionPersona> UbicacionPersonas { get; set; }
    }
}