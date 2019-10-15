using System;
using VendaPS.Domain.Entities;

namespace VendaPS.Domain.Interfaces.Repositories
{
    public interface IProductRepository : IDisposable
    {
        void Add(Product product);
        Product GetByEan(string ean);
    }
}