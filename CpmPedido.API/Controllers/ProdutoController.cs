using System;
using System.Collections.Generic;
using CpmPedido.Domain;
using CpmPedido.Interface.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CpmPedido.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : AppBaseController
    {
        public ProdutoController(IServiceProvider serviceProvider): base(serviceProvider)
        {
        }

        [HttpGet]
        public dynamic Get()
        {
            var rep = (IProdutoRepository)ServiceProvider.GetService(typeof(IProdutoRepository));

            return rep.Get();
        }

        [HttpGet]
        [Route("search/{text}/{pagina?}")]
        public dynamic GetSearch(string text, int pagina = 1)
        {
            var rep = (IProdutoRepository)ServiceProvider.GetService(typeof(IProdutoRepository));
            return rep.Search(text, pagina);
        }

        [HttpGet]
        [Route("{id}")]
        public dynamic Detail(int id)
        {
            if (id > 0)
            {
                var rep = (IProdutoRepository)ServiceProvider.GetService(typeof(IProdutoRepository));
                return rep.Detail(id);
            }

            return null;
        }

        [HttpGet]
        [Route("{id}/imagens")]
        public dynamic Imagnes(int id)
        {
            if (id > 0)
            {
                var rep = (IProdutoRepository)ServiceProvider.GetService(typeof(IProdutoRepository));
                return rep.Imagens(id);
            }

            return null;
        }
    }
}
