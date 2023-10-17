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
    public class RTipoPersona : RGeneric<TipoPersona>, ITipoPersona
    {
        private readonly FarmaciaContext _context;

        public RTipoPersona(FarmaciaContext context) : base(context)
        {
            _context = context;
        }
        public override async Task<IEnumerable<TipoPersona>> GetAllAsync()
        {
            return await _context.TipoPersonas
                        .Include(c => c.Personas)
                        .ToListAsync();
        }

        public override async Task<(int totalRegistros, IEnumerable<TipoPersona> registros)> GetAllAsync(
            int pageIndex,
            int pageSize,
            string search
        )
        {
            var query = _context.TipoDocumentos as IQueryable<TipoPersona>;
        
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