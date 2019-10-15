using System;
using System.Collections.Generic;
using VendaPS.Domain.Entities;

namespace VendaPS.Domain.Interfaces.Repositories
{
    public interface ISaleRepository : IDisposable
    {
        void Add(Sale sale);
        List<Sale> GetAll();
    }
}