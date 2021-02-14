
namespace CpmPedido.Repository
{
        public class BaseRepository
        {
            public readonly ApplicationDbContext DbContext;
            public BaseRepository(ApplicationDbContext dbContext)
            {
                DbContext = dbContext;
            }
        }
}
