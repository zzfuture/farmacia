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
    public class RPais : RGeneric<Pais>, IPais
    {
        private readonly FarmaciaContext _context;

        public RPais(FarmaciaContext context) : base(context)
        {
            _context = context;
        }
        public override async Task<IEnumerable<Pais>> GetAllAsync()
        {
            return await _context.Paises
                        .Include(c => c.Departamentos)
                        .ToListAsync();
        }

        public override async Task<(int totalRegistros, IEnumerable<Pais> registros)> GetAllAsync(
            int pageIndex,
            int pageSize,
            string search
        )
        {
            var query = _context.Paises as IQueryable<Pais>;
        
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