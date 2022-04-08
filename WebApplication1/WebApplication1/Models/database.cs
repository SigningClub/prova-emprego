using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class MyDBContext : DbContext
    {

        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options) { }
    }
}
