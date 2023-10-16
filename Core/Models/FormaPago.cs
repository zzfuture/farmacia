using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class FormaPago : BaseModel
    {
        public string NombreFormaPago { get; set; }
        public ICollection<MovimientoInventario> MovimientoInventarios { get; set; }
    }
}