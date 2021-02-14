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
        public IEnumerable<Produto> Get()
        {
            var rep = (IProdutoRepository)ServiceProvider.GetService(typeof(IProdutoRepository));

            return rep.Get();
        }

        [HttpGet]
        [Route("search/{text}")]
        public IEnumerable<Produto> GetSearch(string text)
        {
            var rep = (IProdutoRepository)ServiceProvider.GetService(typeof(IProdutoRepository));
            return rep.Search(text);
        }

        [HttpGet]
        [Route("{id}")]
        public Produto Detail(int id)
        {
            if (id > 0)
            {
                var rep = (IProdutoRepository)ServiceProvider.GetService(typeof(IProdutoRepository));
                return rep.Detail(id);
            }

            return null;
        }
    }
}
