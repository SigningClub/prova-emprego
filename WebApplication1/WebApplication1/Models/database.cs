using Microsoft.EntityFrameworkCore;

namespace WebApplication1
{
    public class MyDBContext : DbContext
    {

        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options) { }
    }
}
