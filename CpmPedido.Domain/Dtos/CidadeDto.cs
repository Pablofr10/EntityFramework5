using System;
namespace CpmPedido.Domain
{
    public class CidadeDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Uf { get; set; }
        public bool Ativo { get; set; }
    }
}
