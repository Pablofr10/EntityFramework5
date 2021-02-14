using System;
using CpmPedido.Interface.Repositories;
using CpmPedido.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace CpmPedido.API
{
    public class DependencyInjection
    {
        public static void Register(IServiceCollection serviceProvider)
        {
            RepositoryDependence(serviceProvider);
        }
        private static void RepositoryDependence(IServiceCollection serviceProvider)
        {
            serviceProvider.AddScoped<IProdutoRepository, ProdutoRepository>();
        }
    }
}
