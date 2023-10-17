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
    public class RCiudad : RGeneric<Ciudad>, ICiudad
    {
        private readonly FarmaciaContext _context;

        public RCiudad(FarmaciaContext context) : base(context)
        {
            _context = context;
        }
        public override async Task<IEnumerable<Ciudad>> GetAllAsync()
        {
            return await _context.Ciudades
                        .Include(c => c.UbicacionPersonas)
                        .ToListAsync();
        }

        public override async Task<(int totalRegistros, IEnumerable<Ciudad> registros)> GetAllAsync(
            int pageIndex,
            int pageSize,
            string search
        )
        {
            var query = _context.Ciudades as IQueryable<Ciudad>;
        
            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(p => p.NombreCiudad.ToLower().Contains(search)); // If necesary add .ToString() after varQuery
            }
            query = query.OrderBy(p => p.Id);
        
            var totalRegistros = await query.CountAsync();
            var registros = await query
                            .Include(p => p.UbicacionPersonas)
                            .Skip((pageIndex - 1) * pageSize)
                            .Take(pageSize)
                            .ToListAsync();
            return (totalRegistros, registros);
        }
    }
}