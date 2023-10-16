using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class DetalleMovimientoInventario : BaseModel
    {
        public int Cantidad { get; set; }
        public double Precio { get; set; }
        public string IdInventarioFk { get; set; }
        public Inventario Inventarios { get; set; }
        public string IdMovimientoInventarioFk { get; set; }
        public MovimientoInventario MovimientoInventarios { get; set; }
        public ICollection<Factura> Facturas { get; set; }
    }
}