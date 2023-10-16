using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Producto : BaseModelVC
    {
        public string NombreProducto { get; set; }
        public int IdMarcaFk { get; set; }
        public Marca Marcas { get; set; }
        public ICollection<Inventario> Inventarios { get; set; }
    }
}