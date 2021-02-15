using System;
using CpmPedido.Domain;
using CpmPedido.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CpmPedido.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CidadeController : AppBaseController
    {
        public CidadeController(IServiceProvider serviceProvider): base(serviceProvider)
        {
        }

        [HttpGet]
        public dynamic Get()
        {
            return GetService<ICidadeRepository>().Get();
        }

        [HttpPost]
        public int Criar(CidadeDto model)
        {
            return GetService<ICidadeRepository>().Criar(model);

        }

    }
}
