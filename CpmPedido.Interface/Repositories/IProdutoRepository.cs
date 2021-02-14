using System;
using System.Collections.Generic;
using CpmPedido.Domain;

namespace CpmPedido.Interface.Repositories
{
    public interface IProdutoRepository
    {
        List<Produto> Get();
        List<Produto> Search(string text);
        Produto Detail(int id);
    }
}
