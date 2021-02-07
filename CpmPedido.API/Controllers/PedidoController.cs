using System;
using Microsoft.AspNetCore.Mvc;

namespace CpmPedido.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PedidoController : AppBaseController
    {
        public PedidoController(IServiceProvider serviceProvider): base(serviceProvider)
        {
        }
    }
}
