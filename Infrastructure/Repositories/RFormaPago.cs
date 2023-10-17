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
    public class RFormaPago : RGeneric<FormaPago>,IFormaPago
    {
        private readonly FarmaciaContext _context;

        public RFormaPago(FarmaciaContext context) : base(context)
        {
            _context = context;
        }
        public override async Task<IEnumerable<FormaPago>> GetAllAsync()
        {
            return await _context.FormaPagos
                        .Include(c => c.MovimientoInventarios)
                        .ToListAsync();
        }

        public override async Task<(int totalRegistros, IEnumerable<FormaPago> registros)> GetAllAsync(
            int pageIndex,
            int pageSize,
            string search
        )
        {
            var query = _context.FormaPagos as IQueryable<FormaPago>;
        
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