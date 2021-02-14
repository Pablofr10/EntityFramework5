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


        public dynamic Get()
        {
            return DbContext.Produtos
                .Include(x => x.Categoria)
                .Where(x => x.Ativo)
                .Select(x => new
                {
                    x.Nome,
                    x.Preco,
                    Categoria = x.Categoria,
                    x.Imagens
                })
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
                .Select(x => new
                {
                    x.Nome,
                    x.Preco,
                    Categoria = x.Categoria,
                    Imagens = x.Imagens.Select(x => new
                    {
                        x.Id,
                        x.Nome,
                        x.NomeArquivo
                    })
                })
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

        public dynamic Detail(int id)
        {
            return DbContext.Produtos
                .Include(x => x.Imagens)
                .Include(x => x.Categoria)
                .Where(x => x.Id == id)
                .Select(x => new
                {
                    x.Id,
                    x.Nome,
                    x.Codigo,
                    x.Descricao,
                    x.Preco,
                    Categoria = new
                    {
                        x.Categoria.Id,
                        x.Categoria.Nome
                    },
                    Imagens = x.Imagens.Select(x => new
                    {
                        x.Id,
                        x.Nome,
                        x.NomeArquivo
                    })
                })
                .FirstOrDefault();
        }

        public dynamic Imagens(int id)
        {
            return DbContext.Produtos
                .Include(x => x.Imagens)
                .Where(x => x.Id == id)
                .SelectMany(x => x.Imagens, (produto, imagem) => new
                {
                    IdProduto = produto.Id,
                        imagem.Id,
                        imagem.Nome,
                        imagem.NomeArquivo
                })
                .FirstOrDefault();
        }
    }
}
