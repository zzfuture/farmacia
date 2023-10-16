using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Inventario : BaseModelVC
    {
        public string NombreInventario { get; set; }
        public double PrecioInventario { get; set; }
        public int StockActual { get; set; }
        public int StockMinimo { get; set; }
        public int StockMaximo { get; set; }
        public string IdProductoFk { get; set; }
        public Producto Productos { get; set; }
        public int IdPresentacionFk { get; set; }
        public Presentacion Presentaciones { get; set; }
        public ICollection<DetalleMovimientoInventario> DetalleMovimientoInventarios { get; set; }
    }
}