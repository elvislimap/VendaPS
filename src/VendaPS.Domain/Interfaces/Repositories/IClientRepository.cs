using System;
using VendaPS.Domain.Entities;

namespace VendaPS.Domain.Interfaces.Repositories
{
    public interface IClientRepository : IDisposable
    {
        void Add(Client client);
    }
}