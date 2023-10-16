using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Presentacion : BaseModel
    {
        public string NombrePresentacion { get; set; }
        public ICollection<Inventario> Inventarios { get; set; }
    }
}