using System;
using System.Collections.Generic;
using System.Linq;
using VandaPS.Infra.Data.Contexts;
using VendaPS.Domain.Entities;
using VendaPS.Domain.Interfaces.Repositories;

namespace VandaPS.Infra.Data.Repositories
{
    public class SaleRepository : ISaleRepository
    {
        private readonly ContextEf _context;

        public SaleRepository(ContextEf context)
        {
            _context = context;
        }


        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public void Add(Sale sale)
        {
            _context.Sales.Add(sale);
            _context.SaveChanges();
        }

        public List<Sale> GetAll()
        {
            return _context.Sales.ToList();
        }
    }
}
