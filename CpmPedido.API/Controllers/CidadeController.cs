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

        public int Alterar(CidadeDto model)
        {
            return GetService<ICidadeRepository>().Alterar(model);

        }

        [HttpDelete("{id}")]
        public bool Excluir(int id)
        {
            if (id > 0)
            {
                return GetService<ICidadeRepository>().Excluir(id);
            }
            return false;
        }

    }
}
