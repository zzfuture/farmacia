using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Factura : BaseModel
    {
        public int FacturaActual { get; set; }
        public int FacturaInicial { get; set; }
        public int FacturaFinal { get; set; }
        public string NumeroResolucion { get; set; }
        public string IdPersonaFk { get; set; }
        public Persona Personas { get; set; }
        public string IdDetalleMovimientoInventarioFk { get; set; }
        public DetalleMovimientoInventario DetalleMovimientoInventarios { get; set; }
    }
}