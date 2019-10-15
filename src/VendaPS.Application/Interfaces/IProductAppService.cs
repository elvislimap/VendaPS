using VendaPS.Domain.Entities;
using VendaPS.Domain.ValueObjects;

namespace VendaPS.Application.Interfaces
{
    public interface IProductAppService
    {
        Result Add(Product product);
        Result GetByEan(string ean);
    }
}