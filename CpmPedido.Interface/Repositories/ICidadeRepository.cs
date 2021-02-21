using System;
using CpmPedido.Domain;

namespace CpmPedido.Interface
{
    public interface ICidadeRepository
    {
        dynamic Get();
        int Criar(CidadeDto model);
        int Alterar(CidadeDto model);
        bool Excluir(int id);
    }
}
