using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Marca : BaseModel
    {
        public string NombreMarca { get; set; }
        public ICollection<Producto> Productos { get; set; }
    }
}