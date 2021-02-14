using System;
using System.Collections.Generic;
using System.Linq;
using CpmPedido.Domain;
using CpmPedido.Interface.Repositories;
using Microsoft.EntityFrameworkCore;

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
                .Include(x => x.Categoria)
                .Where(x => x.Ativo)
                .OrderBy(x => x.Nome)
                .ToList();
            
        }

        public dynamic Search(string text, int pagina)
        {
            string TEXT = text.ToUpper().Trim();

            var produtos = DbContext.Produtos
                .Include(x => x.Categoria)
                .Where(x => x.Ativo &&
                (x.Nome.ToUpper().Contains(TEXT) || x.Descricao.ToUpper().Contains(TEXT)))
                .Skip(TamanhoPagina * (pagina - 1))
                .Take(TamanhoPagina)
                .OrderBy(x => x.Nome)
                .ToList();

            var quantProdutos = DbContext.Produtos
                .Where(x => x.Ativo && (x.Nome.ToUpper().Contains(TEXT) || x.Descricao.ToUpper().Contains(TEXT)))
                .Count();

            var quantPaginas = (quantProdutos / TamanhoPagina);
            if (quantPaginas < 1)
            {
                quantPaginas = 1;
            }

            return new { produtos, quantPaginas };

        }

        public Produto Detail(int id)
        {
            return DbContext.Produtos
                .Include(x => x.Imagens)
                .Include(x => x.Categoria)
                .Where(x => x.Id == id)
                .FirstOrDefault();
        }
    }
}
