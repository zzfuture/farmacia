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
    public class RMovimientoInventario : RGenericVC<MovimientoInventario>, IMovimientoInventario
    {
        private readonly FarmaciaContext _context;

        public RMovimientoInventario(FarmaciaContext context) : base(context)
        {
            _context = context;
        }
        public override async Task<IEnumerable<MovimientoInventario>> GetAllAsync()
        {
            return await _context.MovimientoInventarios
                        .Include(c => c.DetalleMovimientoInventarios)
                        .ToListAsync();
        }

        public override async Task<(int totalRegistros, IEnumerable<MovimientoInventario> registros)> GetAllAsync(
            int pageIndex,
            int pageSize,
            string search
        )
        {
            var query = _context.MovimientoInventarios as IQueryable<MovimientoInventario>;
        
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