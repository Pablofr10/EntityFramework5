using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace CpmPedido.API.Controllers
{
    public class AppBaseController : Controller
    {
        protected readonly IServiceProvider ServiceProvider;

        public AppBaseController(IServiceProvider serviceProvider)
        {
            ServiceProvider = serviceProvider;
        }

        protected T GetService<T>()
        {
            return ServiceProvider.GetService<T>();
        }
    }
}
