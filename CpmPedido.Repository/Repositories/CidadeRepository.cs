using System.Linq;
using CpmPedido.Domain;
using CpmPedido.Interface;

namespace CpmPedido.Repository
{
    public class CidadeRepository : BaseRepository, ICidadeRepository
    {
        public CidadeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }

        public dynamic Get()
        {
            return DbContext.Cidades
                .Where(x => x.Ativo)
                .Select(x => new
                {
                    x.Id,
                    x.Nome,
                    x.Uf,
                    x.Ativo
                });
        }

        public int Criar(CidadeDto model)
        {
            if (model.Id > 0)
            {
                return 0;
            }

            var nomeDuplicado = DbContext.Cidades.Any(x => x.Ativo && (x.Nome.ToUpper() == model.Nome.ToUpper() && x.Uf.ToUpper() == model.Uf.ToUpper()));

            if (nomeDuplicado)
            {
                return 0;
            }

            try
            {
                var entity = new Cidade()
                {
                    Nome = model.Nome,
                    Uf = model.Uf,
                    Ativo = model.Ativo
                };

                DbContext.Cidades.Add(entity);
                DbContext.SaveChanges();
                return entity.Id;

            }
            catch (System.Exception ex)
            {
            }

            return 0;
        }
    }
}
