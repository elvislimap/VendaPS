using Microsoft.Extensions.DependencyInjection;
using VandaPS.Infra.Data.Repositories;
using VendaPS.Application.Interfaces;
using VendaPS.Application.Services;
using VendaPS.Domain.Interfaces.Repositories;

namespace VendaPS.Infra.CrossCutting.Ioc
{
    public static class ConfigStrapper
    {
        public static void RegisterServices(this IServiceCollection service)
        {
            #region AppServices

            service.AddScoped<IProductAppService, ProductAppService>();

            #endregion

            #region Repositories

            service.AddScoped<IProductRepository, ProductRepository>();
            service.AddScoped<ISaleRepository, SaleRepository>();
            service.AddScoped<IClientRepository, ClientRepository>();

            #endregion
        }
    }
}