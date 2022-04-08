using WebApplication1.Interface;
using WebApplication1.Models;

namespace WebApplication1.Imp
{
    public class ProdutoRepo : IProdutoInterface
    {
        private readonly ProdutoDBContext _dbContext;

        public ProdutoRepo(ProdutoDBContext dbContext )
        {
            _dbContext = dbContext;
        }

        public async Task Add(ProdutoBase produto)
        {
            await _dbContext.AddAsync( produto );
            await _dbContext.SaveChangesAsync();
        }

        public IQueryable<ProdutoBase> GetAll()
        {
            return _dbContext.Produto;
        }
    }
}
