using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Pais : BaseModel
    {
        public string NombrePais { get; set; }
        public ICollection<Departamento> Departamentos { get; set; }
    }
}