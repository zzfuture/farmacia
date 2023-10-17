using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Core.Interfaces
{
    public interface IUnitOfWork
    {
        public ICiudad Ciudades { get; }
        public IContactoPersona ContactoPersonas { get; }
        public IDepartamento Departamentos { get; }
        public IDetalleMovimientoInventario DetalleMovimientoInventarios { get; }
        public IFactura Facturas { get; }
        public IFormaPago FormaPagos { get; }
        public IInventario Inventarios { get; }
        public IMarca Marcas { get; }
        public IMovimientoInventario MovimientoInventarios { get; }
        public IPais Paises { get; }
        public IPersona Personas { get; }
        public IPresentacion Presentaciones { get; }
        public IProducto Productos { get; }
        public IRolPersona RolPersonas { get; }
        public ITipoContacto TipoContactos { get; }
        public ITipoDocumento TipoDocumentos { get; }
        public ITipoMovimientoInventario TipoMovimientoInventarios { get; }
        public ITipoPersona TipoPersonas { get; }
        public IUbicacionPersona UbicacionPersonas { get; }
    }
}