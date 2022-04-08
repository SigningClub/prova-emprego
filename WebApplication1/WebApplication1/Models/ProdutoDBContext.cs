using Microsoft.EntityFrameworkCore;
namespace WebApplication1.Models;

public class ProdutoDBContext : DbContext
{
    public ProdutoDBContext(DbContextOptions options) : base(options)
    {
    } 
    public DbSet<ProdutoBase> Produto { get; set; }
}
