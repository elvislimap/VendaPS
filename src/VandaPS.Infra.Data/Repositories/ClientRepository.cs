using System;
using VandaPS.Infra.Data.Contexts;
using VendaPS.Domain.Entities;
using VendaPS.Domain.Interfaces.Repositories;

namespace VandaPS.Infra.Data.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly ContextEf _context;

        public ClientRepository(ContextEf context)
        {
            _context = context;
        }


        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public void Add(Client client)
        {
            _context.Clients.Add(client);
            _context.SaveChanges();
        }
    }
}