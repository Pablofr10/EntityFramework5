using System;
using System.Collections.Generic;
using CpmPedido.Domain;

namespace CpmPedido.Interface.Repositories
{
    public interface IProdutoRepository
    {
        dynamic Get();
        dynamic Search(string text, int pagina);
        dynamic Detail(int id);
        dynamic Imagens(int id);
    }
}
