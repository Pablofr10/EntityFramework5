using System;
using Microsoft.AspNetCore.Mvc;

namespace CpmPedido.API.Controllers
{
    public class AppBaseController : Controller
    {
        protected readonly IServiceProvider ServiceProvider;

        public AppBaseController(IServiceProvider serviceProvider)
        {
            ServiceProvider = serviceProvider;
        }
    }
}
