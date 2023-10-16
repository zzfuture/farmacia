using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class TipoMovimientoInventario : BaseModel
    {
        public string NombreTipoMovimientoInventario { get; set; }
        public ICollection<MovimientoInventario> MovimientoInventarios { get; set; }
    }
}