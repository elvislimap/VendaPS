using System;
using System.Collections.Generic;

namespace VendaPS.Domain.Entities
{
    public class Client
    {
        public Client()
        {
            
        }

        public int ClientId { get; set; }
        public string Cpf { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        public IEnumerable<Sale> Sales { get; set; }
    }
}