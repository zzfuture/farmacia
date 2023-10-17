using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using Core.Models;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class RInventario : RGenericVC<Inventario>, IInventario
    {
        private readonly FarmaciaContext _context;

        public RInventario(FarmaciaContext context) : base(context)
        {
            _context = context;
        }
        public override async Task<IEnumerable<Inventario>> GetAllAsync()
        {
            return await _context.Inventarios
                        .Include(C => C.DetalleMovimientoInventarios)
                        .ToListAsync();
        }

        public override async Task<(int totalRegistros, IEnumerable<Inventario> registros)> GetAllAsync(
            int pageIndex,
            int pageSize,
            string search
        )
        {
            var query = _context.Inventarios as IQueryable<Inventario>;
        
            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(p => p.Id.ToString().ToLower().Contains(search));
            }
            query = query.OrderBy(p => p.Id);
        
            var totalRegistros = await query.CountAsync();
            var registros = await query
                            .Skip((pageIndex - 1) * pageSize)
                            .Take(pageSize)
                            .ToListAsync();
            return (totalRegistros, registros);
        }
    }
}