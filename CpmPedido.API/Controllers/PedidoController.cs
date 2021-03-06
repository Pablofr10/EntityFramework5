﻿using System;
using System.Collections.Generic;
using CpmPedido.Domain;
using CpmPedido.Interface;
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

        [HttpGet]
        [Route("ticket-maximo")]
        public decimal TicketMaximo()
        {
            var _repo = (IPedidoRepository)ServiceProvider.GetService(typeof(IPedidoRepository));
            return _repo.TicketMaximo();
        }

        [HttpGet]
        [Route("por-cliente")]
        public dynamic PedidosClientes()
        {
            var _repo = (IPedidoRepository)ServiceProvider.GetService(typeof(IPedidoRepository));
            return _repo.PedidosClientes();
        }

    }
}
