using System;
using System.Collections.Generic;
using System.Linq;
using CpmPedido.Domain;
using CpmPedido.Interface.Repositories;

namespace CpmPedido.Repository
{
    public class ProdutoRepository : BaseRepository, IProdutoRepository
    { 
        public ProdutoRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public List<Produto> Get()
        {
            return DbContext.Produtos
                .Where(x => x.Ativo)
                .OrderBy(x => x.Nome).ToList();
            
        }

        public List<Produto> Search(string text)
        {
            string TEXT = text.ToUpper().Trim();

            return DbContext.Produtos
                .Where(x => x.Ativo &&
                (x.Nome.ToUpper().Contains(TEXT) ||
                x.Descricao.ToUpper().Contains(TEXT)))
                .OrderBy(x => x.Nome)
                .ToList();
        }
    }
}
