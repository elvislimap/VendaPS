using System.Collections.Generic;

namespace VendaPS.Domain.Entities
{
    public class Sale
    {
        public int SaleId { get; set; }
        public int ClientId { get; set; }
        public decimal Value { get; set; }

        public Client Client { get; set; }
        public IEnumerable<SaleItem> SaleItems { get; set; }
    }
}