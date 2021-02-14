using System;
using System.Collections.Generic;
using CpmPedido.Domain;

namespace CpmPedido.Interface.Repositories
{
    public interface IProdutoRepository
    {
        List<Produto> Get();
        List<Produto> Search(string text, int pagina);
        Produto Detail(int id);
    }
}
