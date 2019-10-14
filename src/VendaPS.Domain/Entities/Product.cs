using System.Collections.Generic;

namespace VendaPS.Domain.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Ean { get; set; }
        public string Description { get; set; }

        public IEnumerable<SaleItem> SaleItems { get; set; }
    }
}