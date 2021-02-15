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

            var nomeDuplicado = DbContext.Cidades.Any(x => x.Ativo && (x.Nome.ToUpper() == model.Nome.ToUpper() && x.Uf.ToUpper() == model.Uf.ToUpper()) && x.Id != model.Id);

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

        public int Alterar(CidadeDto model)
        {
            if (model.Id <= 0)
            {
                return 0;
            }

            var entity = DbContext.Cidades.Find(model.Id);

            if (entity == null)
            {
                return 0;
            }

            try
            {
                entity.Nome = model.Nome;
                entity.Uf = model.Uf;
                entity.Ativo = model.Ativo;

                DbContext.Cidades.Update(entity);
                DbContext.SaveChanges();

                return entity.Id;
            }
            catch (System.Exception ex)
            {

            }

            return 0;
        }

        public bool Excluir(int id)
        {
            if (id <= 0)
            {
                return false;
            }

            var entity = DbContext.Cidades.Find(id);

            if (entity == null)
            {
                return false;
            }

            try
            {
                DbContext.Cidades.Remove(entity);
                DbContext.SaveChanges();
                return true;
            }
            catch (System.Exception ex)
            {

            }

            return false;
        }
    }
}
